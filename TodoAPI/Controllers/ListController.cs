using Microsoft.AspNetCore.Mvc;

namespace TodoAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ListController : Controller
    {
        public IActionResult GetTodoListById()
        {
            //Implement logic that fethces a specific Todo list by it's ID.

            return Ok();
        }
    }
}
