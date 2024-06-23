using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            _context.TodoItems.Update(item);

            _context.SaveChanges();
        }

        public void DeleteTodoItem(Guid todoItemId)
        {
            var itemToRemove = _context.TodoItems.Find(todoItemId);

            if (itemToRemove != null)
            {
                _context.TodoItems.Remove(itemToRemove);
                _context.SaveChanges();
            }
        }
    }
}
