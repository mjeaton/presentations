using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Xaml_Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
            var b = new Button();
            b.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            b.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            b.Width = 150;

            var sp = new StackPanel();
            sp.Orientation = Orientation.Vertical;

            var tb = new TextBlock();
            tb.Text = "Hello!";
            sp.Children.Add(tb);

            var x = new Image();
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"C:\Users\Michael\Dropbox\Public\MadExpoLogo.png", UriKind.RelativeOrAbsolute);
            image.EndInit();
            x.Source = image;
            sp.Children.Add(x);

            //b.Content = "Hello, St. Louis!";
            b.Content = sp;

            this.Content = b; 
            */
        }
    }
}
