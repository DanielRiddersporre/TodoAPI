using Microsoft.EntityFrameworkCore;
using SimpleTodo.Domain;

namespace SimpleTodo.Infrastructure
{
    public class TodoListRepository : ITodoListRepository
    {
        TodoContext _context;
        public TodoListRepository(TodoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TodoList>> GetAllTodoLists()
        {
            return await _context.TodoLists.ToListAsync();
        }

        public void AddTodoList(TodoList todoList)
        {
            _context.TodoLists.Add(todoList);

            _context.SaveChanges();
        }

        public async Task<bool> DeleteTodoList(Guid id)
        {
            var todoList = await _context.TodoLists.FindAsync(id);

            if (todoList == null)
            {
                return false;
            }

            _context.TodoLists.Remove(todoList);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateTodoList(Guid id)
        {
            var todoList = await _context.TodoLists.FindAsync(id);

            if (todoList == null) 
            {
                return false;
            }

            _context.TodoLists.Update(todoList);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
