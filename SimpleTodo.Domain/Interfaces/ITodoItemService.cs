using SimpleTodo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTodo_Domain.Interfaces
{
    public interface ITodoItemService
    {
        void AddTodoItem(string description, bool isDone, Guid todoListId);
        void UpdateTodoItem(Guid id, string description, bool isDone, Guid todoListId);
        void DeleteTodoItem(Guid id);
    }
}
