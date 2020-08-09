using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey_with_Model.Controllers
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