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
        void AddTodoItem(TodoItem todoItem);
        void UpdateTodoItem(TodoItem todoItem);
        void DeleteTodoItem(Guid id);
    }
}
