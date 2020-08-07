using Microsoft.AspNetCore.Mvc;  // provides Controller class that we inherit below

namespace Platform_Lecture_ASP_MVC_I.Controllers  // added .Controllers to namespace
{
    public class HomeController : Controller  
    // the name given before Controller (Home) is the name of the Views folder for this Controller
    {
        // Request:
        [HttpGet]  // get requests are implicitly there in the background if it's not explicit like this
        [Route("")]  // localhost:5000

        // Response:
        public string Index()
        {
            return "Hello from HomeController!";
        }

        // Request:
        [HttpGet("hello")]  // shorthand for what was done above

        // Response:
        public string Hello()
        {
            return "Hi!";
        }

        // Request:
        [HttpGet("users/(username}")]  // route parameter can be string or int

        // Response:
        public string HelloUser(string username)  // using route parameter
        {
            return $"Hello {username}!"; 
        }

        /*
        // Request:
        [HttpPost("submission")]
        // POST requests to "localhost:5000/submission" go here
        
        // Response:
        public string FormSubmission(string formInput)
        {
            // Method body
        }
        */

        [HttpGet("return_view_example")]
        public ViewResult ReturnViewExample()
        {
            return View("Index");
        }
    }
}