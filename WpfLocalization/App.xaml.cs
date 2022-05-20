using System.Windows;

namespace WpfLocalization;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("he-IL");
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("he-IL");
    }
}