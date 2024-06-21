namespace SimpleTodo.Domain
{
    public interface ITodoListRepository
    {
        void AddTodoList(TodoList todoList);
        public Task<bool> DeleteTodoList(Guid id);
        public Task<bool> UpdateTodoList(Guid id);
    }
}
