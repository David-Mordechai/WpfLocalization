using System.Windows;

namespace WpfLocalization;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var currentLanguage = System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag;
        if (currentLanguage.ToLower().StartsWith("he"))
            FlowDirection = FlowDirection.RightToLeft;
    }
}