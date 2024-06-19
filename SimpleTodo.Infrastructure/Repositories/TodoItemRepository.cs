using Microsoft.EntityFrameworkCore;
using SimpleTodo.Domain;

namespace SimpleTodo.Infrastructure
{
    public class TodoItemRepository : ITodoListRepository
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

        public void AddTodoList(TodoList todoList)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodoList(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoList(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
