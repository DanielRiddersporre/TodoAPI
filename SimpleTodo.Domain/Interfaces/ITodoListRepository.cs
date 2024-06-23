namespace SimpleTodo.Domain
{
    public interface ITodoListRepository
    {
        public Task<IEnumerable<TodoList>> GetAllTodoLists();
        void AddTodoList(TodoList todoList);
    }
}
