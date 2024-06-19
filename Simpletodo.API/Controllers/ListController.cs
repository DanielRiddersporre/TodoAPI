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

        [HttpPost("CreateTodoList")]
        public IActionResult CreateTodoList(string name)
        {
            _todoListService.CreateTodoList(name);
            return Ok();
        }
    }
}
