using Microsoft.AspNetCore.Mvc;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string[] message = new string[] {"Here is my message:", "blah", "blah", "blah"};
            return View(message);
        }


    }
}