using Microsoft.AspNetCore.Mvc;

namespace Learning_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("blocks")]
        public IActionResult Blocks()
        {
            return View();
        }
    }
}