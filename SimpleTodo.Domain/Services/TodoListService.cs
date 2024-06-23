
namespace SimpleTodo.Domain
{
    public class TodoListService : ITodoListService
    {
        ITodoListRepository _TodoListRepository { get; set; }
        public TodoListService(ITodoListRepository todoListRepository)
        {
            _TodoListRepository = todoListRepository;
        }

        public async Task<IEnumerable<TodoList>> GetAllTodoLists()
        {
            return await _TodoListRepository.GetAllTodoLists();
        }

        public void CreateTodoList(string name)
        {
            TodoList todoList = new TodoList()
            {
                Id = new Guid(),
                Name = name
            };

            _TodoListRepository.AddTodoList(todoList);
        }
    }
}
