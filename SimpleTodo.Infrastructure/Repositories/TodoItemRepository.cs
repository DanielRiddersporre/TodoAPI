using Microsoft.EntityFrameworkCore;
using SimpleTodo.Domain;

namespace SimpleTodo.Infrastructure
{
    public class TodoItemRepository : ITodoItemRepository
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
            _context.TodoItems.Add(item);

            _context.SaveChanges();
        }

        public void UpdateTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoItemById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
