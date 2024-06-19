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

        public void AddTodoList(TodoList todoList)
        {
            _context.TodoLists.Add(todoList);

            _context.SaveChanges();
        }

        public void DeleteTodoList(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodoList(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
