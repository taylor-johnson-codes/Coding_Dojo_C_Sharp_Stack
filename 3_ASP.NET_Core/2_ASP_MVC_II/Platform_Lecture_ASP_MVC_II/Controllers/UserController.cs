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


        [HttpPost("process")]
        public IActionResult Process(User user1)
        {
            return View("NewUser", user1);
        }
        // if I need to send more than user1, use ViewBag because only one model can be sent


        [HttpGet("add_new_user")]
        public IActionResult AddNewUser()
        {
            return View();
        }

        /*
        Validations will automatically run/be triggered.
        ModelState is a dictionary that contains information about the most recent model we've run validations on, 
        including any errors found. Its IsValid property will return a boolean--true if no errors were found, 
        and false if there were any errors.
        */
        [HttpPost("add")]
        public IActionResult Add(User user2)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", user2);
            }
            else
            {
                return View("AddNewUser");
            }
        }

        [HttpGet("success")]
        public IActionResult Success(User user2)
        {
            return View("Success", user2);
        }
    }
}