namespace SimpleTodo.Domain
{
    public class TodoListService : ITodoListService
    {
        ITodoListRepository _TodoListRepository { get; set; }
        public TodoListService(ITodoListRepository todoListRepository)
        {
            _TodoListRepository = todoListRepository;
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

        public void DeleteTodoList(Guid id)
        {
            _TodoListRepository.DeleteTodoList(id);
        }

        public void UpdateTodoList(Guid id)
        {
            _TodoListRepository.UpdateTodoList(id);
        }
    }
}
