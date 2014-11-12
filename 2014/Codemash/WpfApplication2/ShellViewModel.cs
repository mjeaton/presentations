using System.Windows;
using Caliburn.Micro;

namespace WpfApplication2
{
    public class ShellViewModel : Screen, IShell 
    {
        private string _firstName;
        public ShellViewModel()
        {
            FirstName = "Nigel";
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange();
                NotifyOfPropertyChange(() => CanClickMe);
            }
        }

        public void ClickMe()
        {
            //MessageBox.Show("I was clicked");
			// Save to the database
        }

        public bool CanClickMe
        {
            get
            {
                return !string.IsNullOrEmpty(FirstName);
            }
        }
    }
}