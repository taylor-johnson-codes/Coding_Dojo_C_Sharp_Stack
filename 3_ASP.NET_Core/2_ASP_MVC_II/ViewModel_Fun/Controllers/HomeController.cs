using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Here is my message: blah blah blah.";
            return View("Index", message);
            // Have to explicitly say "Index" here because message and Index are both strings, so without "Index"
            // it's looking for a view called message
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[] {1,2,3,4,5};
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> user_list = new List<User>()
            {
                new User() {FirstName="Taylor", LastName="Johnson"},
                new User() {FirstName="Mac", LastName="Dog"},
            };
            return View(user_list);
        }

        [HttpGet("user")]
        public IActionResult NewUser()
        {
            User user1 = new User();
            user1.FirstName = "Taylor";
            user1.LastName = "Johnson";
            return View(user1);
        }
    }
}