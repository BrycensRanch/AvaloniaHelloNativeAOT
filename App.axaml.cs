using Avalonia;
using Avalonia.Markup.Xaml;
using AvaloniaHelloNativeAOT.Views;

namespace AvaloniaHelloNativeAOT;

public class App : Application
{
    public App()
    {
        DataContext = this;
    }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
#if DEBUG
        Current!.AttachDevTools();
#endif
    }

    public override void OnFrameworkInitializationCompleted()
    {
        new MainWindow().Show();
    }
}
