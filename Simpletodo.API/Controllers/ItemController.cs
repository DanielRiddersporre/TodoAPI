using Microsoft.AspNetCore.Mvc;
using SimpleTodo.Domain;

namespace SimpleTodo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private static List<TodoItem> todoItems = new List<TodoItem>();

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetTodoItems()
        {
            return todoItems;
        }

        [HttpPost("{item}")]
        public ActionResult<TodoItem> AddTodoItem(TodoItem item)
        {
            item.Id = Guid.NewGuid();
            
            todoItems.Add(item);
            
            return Ok(todoItems);
        }

        [HttpPut("{item}")]
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

        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(Guid id)
        {
            var todoItem = todoItems.SingleOrDefault(item => item.Id == id);
            if (todoItem != null)
            {
                todoItems.Remove(todoItem); 
                return Ok($"{todoItem} deleted successfully!");
            }
            return BadRequest($"Item with {id} was not found");
        }
    }
}
