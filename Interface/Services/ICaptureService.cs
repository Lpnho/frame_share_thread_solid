using Emgu.CV;

namespace FrameShare.Interface.Services;
public abstract class ICaptureService
{
    public bool IsRunning { get; protected set; }
    public abstract void StartCapture(string captureData);
    public abstract void EndCapture();
    public abstract Mat? QueryFrame();
}
