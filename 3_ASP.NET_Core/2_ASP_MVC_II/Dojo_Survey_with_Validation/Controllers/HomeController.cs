using Dojo_Survey_with_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey_with_Validation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Survey new_survey)
        {
            if(ModelState.IsValid)
            {
                return View("Result", new_survey);
            }
            else
            {
                return View("Index");
            }
        }

        // [HttpGet("result")]
        // public IActionResult Result(Survey new_survey)
        // {
        //     return View("Result", new_survey);
        // }
    }
}