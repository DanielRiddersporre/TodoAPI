using Microsoft.EntityFrameworkCore;
using SimpleTodo_Domain;
using SimpleTodo_Domain.Interfaces;

namespace TodoAPI_Infrastructure.Repositories
{
    internal class TodoItemRepository : ITodoItemRepository
    {
        private readonly TodoContext _context;

        public TodoItemRepository(TodoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TodoItem>> GetAllTodoItemsByTodoListId(Guid TodoListId)
        {
            return await _context.TodoItems.Where(t => t.TodoListId == TodoListId).ToListAsync();
        }

        public void AddTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoItemById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
