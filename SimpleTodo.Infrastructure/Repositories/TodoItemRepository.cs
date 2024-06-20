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

        void ITodoItemRepository.AddTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        void ITodoItemRepository.UpdateTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        void ITodoItemRepository.DeleteTodoItemById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
