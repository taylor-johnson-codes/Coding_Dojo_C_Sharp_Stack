using Microsoft.AspNetCore.Mvc;

namespace Multiple_Forms_Single_View.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}