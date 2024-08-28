namespace FrameShare.Interface.Views;
public interface IStreamView : ILoggableView
{
    public event EventHandler? StartStream;

    public event EventHandler? EndStream;
    public string IpAddress { get; set; }
}
