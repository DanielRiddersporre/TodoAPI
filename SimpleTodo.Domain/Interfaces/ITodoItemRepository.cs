namespace SimpleTodo.Domain
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetAllTodoItemsByTodoListId(Guid TodoListId);
        void AddTodoItem(TodoItem item);
        void UpdateTodoItem(TodoItem item);
        void DeleteTodoItemById(Guid Id);
    }
}
