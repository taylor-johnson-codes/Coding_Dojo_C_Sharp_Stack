using Dojo_Survey_with_Model.Models;
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

        [HttpPost("process")]
        public IActionResult Process(Survey survey1)
        {
            return View("Result", survey1);
        }
    }
}