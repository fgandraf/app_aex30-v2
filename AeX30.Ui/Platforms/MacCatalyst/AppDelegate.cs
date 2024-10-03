using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AeX30.Ui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}