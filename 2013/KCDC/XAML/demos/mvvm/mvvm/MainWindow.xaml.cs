using System.Windows;

namespace mvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var p = new Person { FirstName = "John", LastName = "Doe" };
            this.DataContext = new PersonViewModel(p);
        }
    }
}
