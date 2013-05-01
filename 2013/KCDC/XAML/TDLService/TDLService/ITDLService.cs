using System.Collections.Generic;
using IntroToXAMLWithWPF.Models;

namespace IntroToXAMLWithWPF.Service
{
    public interface ITdlService
    {
        List<ToDoListItem> GetAllTasks(bool includeArchived);

        List<ToDoListItem> GetTasksForOwner(Person owner, bool includeArchived);

        void SaveTask(ToDoListItem itemToSave);
        void DeleteTask(ToDoListItem itemToDelete);
    }
}