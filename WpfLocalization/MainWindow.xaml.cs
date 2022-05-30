using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using Svg;

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

        TextToBitmap();
    }

    private void TextToBitmap()
    {
        try
        {
            const string text = "<svg viewBox=\"0 0 500 120\" xmlns=\"http://www.w3.org/2000/svg\">\r\n  <rect width=\"300\" height=\"100\" x=\"60\" y=\"10\" rx=\"10\" ry=\"10\" style=\"fill:rgb(255,0,127);stroke-width:3;stroke:rgb(0,0,0)\"/>\r\n</svg>";

            var mySvg = SvgDocument.FromSvg<SvgDocument>(text);
            var myBmp = mySvg.Draw();
            using var stream = new MemoryStream();
            myBmp.Save(stream, ImageFormat.Bmp);
            var bitmap = new BitmapImage
            {
                StreamSource = stream
            };
            Image1.Source = bitmap;
        }
        catch
        {
            MessageBox.Show("Fail to load SVG.");
        }
    }
}