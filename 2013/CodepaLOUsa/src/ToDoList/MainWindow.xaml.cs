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

        public ObservableCollection<Person> People { get; set; }
        public ObservableCollection<ToDoItem> TodoList { get; set; }
        public MainWindow() 
        {
            InitializeComponent();

            TodoList = new ObservableCollection<ToDoItem>(getAllTasks());
            People = new ObservableCollection<Person>(getEmployees());

            blah.Content = new Person() { FirstName = "john", LastName = "doe" };

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

        private List<Person> getEmployees()
        {
            var people = new List<Person>();
            people.Add(new Person() { FirstName = "mike", LastName = "eaton", HomeAddress = new Address() { Number = "8", State = "MI", Street = "Blah", City = "Coldwater" }});
            people.Add(new Person() { FirstName = "james", LastName = "bender", HomeAddress = new Address() { Number = "8", State = "OH", Street = "Blah", City = "Columbus" }});

            return people;
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TodoList.Add(new ToDoItem() { Title = "Mike's New Task", Description = "Added by the button", DueDate = DateTime.Today.AddDays(1) });

            Console.WriteLine("stop");
        }
    }
}

namespace ToDoList.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address HomeAddress { get; set; }
    }
  
    public class Address
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
