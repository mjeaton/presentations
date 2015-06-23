using System;
using System.Linq;
using IntroToXAMLWithWPF.Models;
using IntroToXAMLWithWPF.Service;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
    public class Test1 
    {
		[Test]
        public void NewToDoItemShouldNotBeNull()
        {
            var newItem = ToDoListItem.GetNewTask();
            Assert.That(newItem != null);
        }

		[Test]
        public void NewItemShouldHaveNonEmptyGuid()
        {
            var newItem = ToDoListItem.GetNewTask();
            Assert.That(newItem.UniqueId.ToString() != string.Empty);
        }
    }
}
