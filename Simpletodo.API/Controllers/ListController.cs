using Microsoft.AspNetCore.Mvc;
using SimpleTodo.Domain;

namespace SimpleTodo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ListController : Controller
    {
        ITodoListService _todoListService { get; set; }
        public ListController(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpGet("GetAllTodoLists")]
        public async Task<IActionResult> GetAllTodoLists()
        {
            var todoLists = await _todoListService.GetAllTodoLists();

            return Ok(todoLists);
        }

        [HttpPost("CreateTodoList")]
        public IActionResult CreateTodoList(string name)
        {
            _todoListService.CreateTodoList(name);
            return Ok();
        }
    }
}
