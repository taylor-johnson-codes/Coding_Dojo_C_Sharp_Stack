using Microsoft.AspNetCore.Mvc;
using Platform_Lecture_ASP_MVC_II.Models;

namespace Platform_Lecture_ASP_MVC_II.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // While being hard-coded here, this user instance will eventually come from our DB

            User someUser = new User() {FirstName = "Taylor", LastName = "Johnson"};
            return View(someUser);

            // If we also need to include the name of our View, we pass our instance as a second argument
            // return View("OtherView", someUser);
        }
    }
}