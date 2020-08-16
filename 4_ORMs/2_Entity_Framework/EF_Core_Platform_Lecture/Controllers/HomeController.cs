using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace EF_Core_Platform_Lecture.Controllers
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