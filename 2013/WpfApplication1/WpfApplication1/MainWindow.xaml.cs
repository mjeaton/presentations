using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<TodoItem> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Items = new ObservableCollection<TodoItem>();
            Items.Add(new TodoItem { Title = "Test 1", Description = "This is item 1", DueDate = DateTime.Today.AddDays(2), Owner = "mike", Priority = "low" });
            Items.Add(new TodoItem { Title = "Test 2", Description = "This is item 2", DueDate = DateTime.Today.AddDays(6), Owner = "tim", Priority = "high" });
            Items.Add(new TodoItem { Title = "Test 3", Description = "This is item 3", DueDate = DateTime.Today.AddDays(3), Owner = "mike", Priority = "medium" });
            Items.Add(new TodoItem { Title = "Test 4", Description = "This is item 4", DueDate = DateTime.Today.AddDays(-1), Owner = "jeff", Priority = "low" });

            this.DataContext = this;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
