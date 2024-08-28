using Emgu.CV;

namespace FrameShare.Interface.Views;

public interface ICaptureView : ILoggableView
{
    public void OnCaptureUpdate(Mat frame);
    public string CaptureSource { get; set; }

    public event EventHandler? StartCapture;

    public event EventHandler? EndCapture;
}
