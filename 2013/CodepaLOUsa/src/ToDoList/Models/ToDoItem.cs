using System;
using System.ComponentModel;
using System.Linq;

namespace ToDoList.Models
{
    public class ToDoItem : INotifyPropertyChanged
    {
        private string _title;
        public string Title 
        {
            get { return _title; }
            set
            {
                if (_title == value)
                    return;
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }

        private DateTime _dueDate;
        public DateTime DueDate 
        {
            get { return _dueDate; }
            set
            {
                if (_dueDate == value)
                    return;
                _dueDate = value;
                NotifyPropertyChanged("DueDate");
            }
        }

        private string _description;
        public string Description 
        {
            get { return _description; }
            set
            {
                if (_description == value)
                    return;
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}