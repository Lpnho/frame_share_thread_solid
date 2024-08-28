using Emgu.CV;
using FrameShare.Interface.Services;

namespace FrameShare.Services;
public class CaptureService : ICaptureService
{
    private Thread? _thread;
    private Object _lockCapture;
    private VideoCapture? _videoCapture;
    private Mat? _lastImage;
    public CaptureService()
    {
        _lockCapture = new Object();
    }
    public override void StartCapture(String captureData)
    {
        if (IsRunning) return;
        IsRunning = true;
        _thread = new Thread(() => Capture(captureData));
        _thread.Start();
    }
    public override void EndCapture()
    {
        if (!IsRunning) return;
        IsRunning = false;
        _thread = null;
        _videoCapture?.Dispose();
        _videoCapture = null;
    }
    public override Mat? QueryFrame()
    {
        lock (_lockCapture)
        {
            var clone = _lastImage?.Clone();
            Monitor.PulseAll(_lockCapture);
            return clone;
        }
    }
    public void Capture(String captureData)
    {
        _videoCapture = new VideoCapture(captureData);
        lock (_lockCapture)
        {
            while (IsRunning)
            {
                var frame = _videoCapture.QueryFrame();
                _lastImage = frame;
                Thread.Sleep(1000 / 60);
                Monitor.Wait(_lockCapture);
            }
        }
    }

}
