using Microsoft.AspNetCore.Mvc;

namespace TodoAPI.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
