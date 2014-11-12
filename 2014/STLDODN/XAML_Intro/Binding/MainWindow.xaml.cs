using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Binding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = GetPeople();
        }

        public List<Person> GetPeople()
        {
            var retVal = new List<Person>();

            retVal.Add(new Person() { FirstName = "John", LastName = "Doe", HireDate=new DateTime(2010, 01,01) });
            retVal.Add(new Person() { FirstName = "Bob", LastName = "Smith", HireDate=new DateTime(2012, 10, 20) });

            return retVal; 
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime HireDate { get; set; }
    }
}
