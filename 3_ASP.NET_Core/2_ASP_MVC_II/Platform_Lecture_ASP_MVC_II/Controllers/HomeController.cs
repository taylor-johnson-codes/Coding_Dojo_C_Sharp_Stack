using Microsoft.AspNetCore.Mvc;

namespace Platform_Lecture_ASP_MVC_II.Controllers
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