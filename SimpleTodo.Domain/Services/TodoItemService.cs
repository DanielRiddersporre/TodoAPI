using SimpleTodo_Domain.Interfaces;

namespace SimpleTodo.Domain
{
    public class TodoItemService : ITodoItemService
    {
        ITodoItemRepository _TodoItemRepository { get; set; }
        
        public TodoItemService(ITodoItemRepository todoItemRepository)
        {
            _TodoItemRepository = todoItemRepository;
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodoItem(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
