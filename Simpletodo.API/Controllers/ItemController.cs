using Microsoft.AspNetCore.Mvc;
using SimpleTodo.Domain;
using SimpleTodo.Infrastructure;

namespace SimpleTodo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        ITodoItemRepository _todoItemRepository { get; set; }
        public ItemController(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItemsByTodoListId(Guid todoListId)
        {
            return Ok(await _todoItemRepository.GetAllTodoItemsByTodoListId(todoListId));
        }

        [HttpPost]
        public ActionResult<TodoItem> AddTodoItem(Guid todoListId, string description, bool isDone)
        {
            TodoItem todoItem = new TodoItem
            {
                Id = Guid.NewGuid(),
                Description = description,
                IsDone = isDone,
                TodoListId = todoListId
            };

            _todoItemRepository.AddTodoItem(todoItem);
            
            return Ok($"TodoItem added!");
        }

        [HttpPut]
        public ActionResult<TodoItem> UpdateTodoItem(TodoItem todoItem)
        {
            _todoItemRepository.UpdateTodoItem(todoItem);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(Guid todoItemId)
        {
            _todoItemRepository.DeleteTodoItem(todoItemId);

            return Ok();
        }
    }
}
