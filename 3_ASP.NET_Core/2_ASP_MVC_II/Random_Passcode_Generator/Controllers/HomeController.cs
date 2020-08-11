using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Random_Passcode_Generator.Controllers
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