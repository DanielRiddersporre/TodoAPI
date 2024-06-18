using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTodo_Domain.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetAllTodoItemsByTodoListId(Guid TodoListId);
        void AddTodoItem(TodoItem item);
        void UpdateTodoItem(TodoItem item);
        void DeleteTodoItemById(Guid Id);
    }
}
