using Emgu.CV;
using FrameShare.Interface.Views;

namespace FrameShare
{
    public partial class MainForm : Form, ICaptureView, IStreamView
    {
        private bool _isStreamRunning = false;
        private bool _isCaptureRunning = false;

        public event EventHandler? StartStream;
        public event EventHandler? EndStream;
        public event EventHandler? StartCapture;
        public event EventHandler? EndCapture;
        public String IpAddress
        {
            get => ipAddress.Text;
            set => ipAddress.Text = value;
        }
        public String CaptureSource
        {
            get => captureSource.Text;
            set => captureSource.Text = value;
        }

        public MainForm()
        {
            InitializeComponent();
            captureButton.Click += delegate { CaptureManageState(); };
            streamButton.Click += delegate { StreamManageState(); };
            UpdateViewComponenets();
        }
        private void UpdateViewComponenets()
        {
            captureButton.Text = (_isCaptureRunning) ? "Desabilitar Captura" : "Habilitar Captura";
            streamButton.Text = (_isStreamRunning) ? "Desabilitar Compartilhamento" : "Habilitar Compartilhamento";
        }
        public void CaptureManageState()
        {
            if (String.IsNullOrEmpty(CaptureSource))
            {
                MessageBox.Show("É necessário definir a origem de captura antes de prossegir!");
                return;
            }
            ((_isCaptureRunning) ? EndCapture : StartCapture)?.Invoke(this, EventArgs.Empty);
            _isCaptureRunning = !_isCaptureRunning;
            UpdateViewComponenets();
        }
        public void StreamManageState()
        {
            if (String.IsNullOrEmpty(IpAddress))
            {
                MessageBox.Show("É necessário definir um destino de compartilhamento antes de prossegir!");
                return;
            }
            ((_isStreamRunning) ? EndStream : StartStream)?.Invoke(this, EventArgs.Empty);
            _isStreamRunning = !_isStreamRunning;
            UpdateViewComponenets();
        }
        public void LogInformation(string data)
        {
            logBox.Text += $"{data}\n";
        }
        public void OnCaptureUpdate(Mat frame)
        {
            throw new NotImplementedException();
        }

    }
}
