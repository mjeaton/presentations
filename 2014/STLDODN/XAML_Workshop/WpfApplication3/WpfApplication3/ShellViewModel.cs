using System.Windows;

namespace WpfApplication3 
{
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        private string _firstName;

        public bool CanSayHello
        {
            get { return !string.IsNullOrEmpty(FirstName); }
        }

        public void SayHello()
        {
            MessageBox.Show("Hello, " + FirstName);
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }
    }
}