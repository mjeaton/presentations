using System;
using System.Linq;

namespace DataTemplates
{
    public class TodoItem
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
    }
}
