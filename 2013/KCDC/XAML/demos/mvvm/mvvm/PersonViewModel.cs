using System.ComponentModel;
using System.Windows.Input;

namespace mvvm
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public PersonViewModel(Person personToView)
        {
            FullName = string.Format("{0} {1}", personToView.FirstName, personToView.LastName);
        }

        private string fullName;
        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public static readonly RoutedUICommand Save = new RoutedUICommand("Save", "saveEvent");
    }
}
