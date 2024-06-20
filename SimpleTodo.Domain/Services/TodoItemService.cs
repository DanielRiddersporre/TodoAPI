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

        public void AddTodoItem(string description, bool isDone, Guid todoListId)
        {
            TodoItem todoItem = new TodoItem
            {
                Id = Guid.NewGuid(),
                Description = description,
                IsDone = isDone,
                TodoListId = todoListId
            };

            _TodoItemRepository.AddTodoItem(todoItem);
        }

        public void UpdateTodoItem(Guid id, string name, bool isDone, Guid todoListId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
