﻿namespace SimpleTodo.Domain
{
    public interface ITodoItemRepository
    {
        public Task<IEnumerable<TodoItem>> GetAllTodoItemsByTodoListId(Guid TodoListId);
        public void AddTodoItem(TodoItem item);
        public void UpdateTodoItem(TodoItem item);
        public void DeleteTodoItemById(TodoItem item);
    }
}
