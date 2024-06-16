using Microsoft.AspNetCore.Mvc;

namespace TodoAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private static List<TodoItem> todoItems = new List<TodoItem>();

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetTodoItems()
        {
            return todoItems;
        }

        [HttpPost]
        public ActionResult<TodoItem> AddTodoItem(TodoItem item)
        {
            item.Id = Guid.NewGuid();
            
            todoItems.Add(item);
            
            return Ok(todoItems);
        }

        [HttpPut]
        public ActionResult<TodoItem> UpdateTodoItem(TodoItem item)
        {
            var itemToEdit = todoItems.SingleOrDefault(i => i.Id == item.Id);

            if(itemToEdit != null)
            {
                itemToEdit.Description = item.Description;
                itemToEdit.IsDone = item.IsDone;
                return Ok(itemToEdit);
            }
            return BadRequest("No item found");
        }

        [HttpPut]
        public ActionResult DeleteTodoItem(Guid id)
        {
            var todoItem = todoItems.SingleOrDefault(item => item.Id == id);
            todoItems.Remove(todoItem);
            return Ok(todoItems);
        }
    }
}
