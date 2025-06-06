// See https://aka.ms/new-console-template for more information

using Avalonia;
using AvaloniaHelloNativeAOT;

Console.WriteLine("Initializing Avalonia");
BuildAvaloniaApp()
    .StartWithClassicDesktopLifetime(args);

static AppBuilder BuildAvaloniaApp()
{
    return AppBuilder.Configure<App>()
        .UsePlatformDetect()
		.LogToTrace();
}