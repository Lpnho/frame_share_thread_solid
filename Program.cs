using Autofac;
using FrameShare.Interface.Services;
using FrameShare.Interface.Views;
using FrameShare.Presenter;
using FrameShare.Services;

namespace FrameShare;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var builder = new ContainerBuilder();
        var mainForm = new MainForm();

        builder.RegisterInstance(mainForm)
            .As<ILoggableView>()
            .As<ICaptureView>()
            .As<IStreamView>();

        builder.RegisterType<CaptureService>().As<ICaptureService>();
        builder.RegisterType<StreamService>().As<IStreamService>();
        builder.RegisterType<FrameSharePresenter>();

        var container = builder.Build();
        using var scope = container.BeginLifetimeScope();
        var frameSharePresenter = scope.Resolve<FrameSharePresenter>();

        Application.Run(mainForm);
    }
}