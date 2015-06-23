using System;
using System.Linq;

namespace IntroToXAMLWithWPF.Models
{
    public enum Priority
    {
		High,
		Medium,
		Low
    }

    public class ToDoListItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Person Owner { get; set; }
        public bool IsArchived { get; set; }
        public Guid UniqueId { get; private set; }

        public static ToDoListItem GetNewTask()
        {
            return new ToDoListItem() { UniqueId = Guid.NewGuid() };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
    }
}
