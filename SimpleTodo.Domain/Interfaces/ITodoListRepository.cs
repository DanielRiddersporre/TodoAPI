namespace SimpleTodo.Domain
{
    public interface ITodoListRepository
    {
        void AddTodoList(TodoList todoList);
        void UpdateTodoList(Guid id);
        void DeleteTodoList(Guid id);
    }
}
