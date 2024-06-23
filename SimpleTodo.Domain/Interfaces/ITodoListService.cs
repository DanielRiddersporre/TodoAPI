namespace SimpleTodo.Domain
{
    public interface ITodoListService
    {
        Task<IEnumerable<TodoList>> GetAllTodoLists();
        void CreateTodoList(string name);
    }
}
