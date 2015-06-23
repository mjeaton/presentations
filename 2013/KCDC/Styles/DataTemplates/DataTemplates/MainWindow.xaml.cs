using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace DataTemplates
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<TodoItem> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Items = new ObservableCollection<TodoItem>();
            Items.Add(new TodoItem { Title = "Item 1", Description = "Description 1", DueDate = DateTime.Today.AddDays(1), Owner = "mike", Priority = "high" });
            Items.Add(new TodoItem { Title = "Item 2", Description = "Description 2", DueDate = DateTime.Today.AddDays(5), Owner = "tom", Priority = "low" });
            Items.Add(new TodoItem { Title = "Item 3", Description = "Description 3", DueDate = DateTime.Today.AddDays(1), Owner = "mike", Priority = "medium" });
            Items.Add(new TodoItem { Title = "Item 4", Description = "Description 4", DueDate = DateTime.Today.AddDays(-1), Owner = "phil", Priority = "high" });
            Items.Add(new TodoItem { Title = "Item 5", Description = "Description 5", DueDate = DateTime.Today.AddDays(10), Owner = "phil", Priority = "low" });

            this.DataContext = this;
        }
    }
}
