using System.Net;
using System.Net.Sockets;

namespace FrameShare.Services;

public class StreamService : IStreamService
{
    private UdpClient? _udpClient;
    private Thread? _thread;
    private IPAddress? _multicastEndPoint;
    private Byte[]? _streamData;
    private Object _lockStream;
    public StreamService()
    {
        _lockStream = new Object();
    }
    private void Stream()
    {
        lock (_lockStream)
        {
            while (IsRunning)
            {
                if (_streamData != null)
                {
                    _udpClient?.Send(_streamData);
                }
                Monitor.Wait(_lockStream);
            }
        }
    }
    public override void Stream(Byte[] data)
    {
        lock (_lockStream)
        {
            _streamData = data;
            Monitor.Pulse(_lockStream);
        }
    }
    public override void StartStream(String ipEndPoint)
    {
        if (IsRunning) return;
        _multicastEndPoint = IPAddress.Parse(ipEndPoint);
        _udpClient = new UdpClient();
        _udpClient.JoinMulticastGroup(_multicastEndPoint);
        IsRunning = true;
        _thread = new Thread(Stream);
        _thread.Start();
    }
    public override void EndStream()
    {
        if (!IsRunning) return;
        IsRunning = false;
        _thread = null;
        _udpClient?.Dispose();
        _udpClient = null;
    }
}