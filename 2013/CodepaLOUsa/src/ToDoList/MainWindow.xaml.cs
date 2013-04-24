using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using ToDoList.Models;

namespace ToDoList
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ToDoItem _task;
        public ToDoItem Task 
        {
            get { return _task; }
            set
            {
                if (_task == value)
                    return;

                _task = value;
                NotifyPropertyChanged("Task");
            }
        }

        public ObservableCollection<ToDoItem> TodoList { get; set; }
        public MainWindow() 
        {
            InitializeComponent();

            TodoList = new ObservableCollection<ToDoItem>(getAllTasks());

            this.DataContext = this;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TodoList.Add(Task);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TodoList.Remove(Task);
        }

        // this could be from a web service or database call
        private IList<ToDoItem> getAllTasks()
        {
            var list = new List<ToDoItem>();

            list.Add(new ToDoItem() { Title = "Task 1", DueDate = DateTime.Today.AddDays(5), Description = "Do stuff" });
            list.Add(new ToDoItem() { Title = "Task 2", DueDate = DateTime.Today.AddDays(15), Description = "Do more stuff" });
            list.Add(new ToDoItem() { Title = "Task 3", DueDate = DateTime.Today.AddDays(-5), Description = "Do even more stuff than before" });
            list.Add(new ToDoItem() { Title = "Task 4", DueDate = DateTime.Today.AddDays(2), Description = "End up on the 6 o'clock new for doing too much stuff" });

            return list;
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
