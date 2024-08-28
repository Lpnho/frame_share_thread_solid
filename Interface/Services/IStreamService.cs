using System.Net;
public abstract class IStreamService
{
    public bool IsRunning { get; protected set; }
    public abstract void Stream(Byte[] data);
    public abstract void StartStream(String ipEndPoint);
    public abstract void EndStream();
}
