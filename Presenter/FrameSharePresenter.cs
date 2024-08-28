using Emgu.CV.Structure;
using FrameShare.Interface.Services;
using FrameShare.Interface.Views;

namespace FrameShare.Presenter;
public class FrameSharePresenter
{
    private ILoggableView _logger;
    private ICaptureView _captureView;
    private IStreamView _streamView;

    private ICaptureService _captureService;
    private IStreamService _streamService;

    private Thread? _thread;
    public bool IsRunning;
    public FrameSharePresenter(
        ILoggableView logger,
        ICaptureView captureView,
        IStreamView streamView,
        ICaptureService captureService,
        IStreamService streamService)
    {
        _logger = logger;
        _captureView = captureView;
        _streamView = streamView;
        _captureService = captureService;
        _streamService = streamService;
        IsRunning = false;
        BindFormEvents();
    }
    private void BindFormEvents()
    {
        _captureView.StartCapture += delegate
        {
            _logger.LogInformation($"Habilitando Captura em: {_captureView.CaptureSource}");
            _captureService.StartCapture(_captureView.CaptureSource);
        };
        _captureView.EndCapture += delegate
        {
            _logger.LogInformation("Desabilitando Captura");
            _captureService.EndCapture();
        };

        _streamView.StartStream += delegate
        {
            _logger.LogInformation($"Habilitando Stream em: {_streamView.IpAddress}");
            _streamService.StartStream(_streamView.IpAddress);
        };
        _streamView.EndStream += delegate
        {
            _logger.LogInformation("Desabilitando Stream");
            _streamService.EndStream();
        };
    }
    public void ApplicationRun()
    {
        if (IsRunning) return;
        IsRunning = true;
        _thread = new Thread(Application);
    }
    public void ApplicationStop()
    {
        if (!IsRunning) return;
        IsRunning = false;
        _thread = null;
    }
    private void Application()
    {
        while (IsRunning)
        {
            if (_captureService.IsRunning)
            {
                ProcessFrame();
            }
            else
            {
                Thread.Sleep(1000);
            }
        }
    }
    private void ProcessFrame()
    {
        var frame = _captureService.QueryFrame();
        if (frame == null) return;

        _captureView.OnCaptureUpdate(frame);
        if (_streamService.IsRunning)
        {
            _streamService.Stream(frame.ToImage<Bgr, Byte>().Bytes);
        }

    }
}
