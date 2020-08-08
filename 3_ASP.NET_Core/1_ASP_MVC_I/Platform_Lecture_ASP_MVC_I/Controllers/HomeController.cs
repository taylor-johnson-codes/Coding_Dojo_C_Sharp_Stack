using System;
using Microsoft.AspNetCore.Mvc;  // provides Controller class that we inherit below

namespace Platform_Lecture_ASP_MVC_I.Controllers  // added .Controllers to namespace; S at end
{
    public class HomeController : Controller  // no S at end
    // the name given before my Controller (Home) is the name of the Views folder for this Controller
    // methods in Controllers are called Actions
    {
        // Request:
        [HttpGet]  // get requests are implicitly there in the background if it's not explicit like this
        [Route("")]  // localhost:5000

        // Response:
        public string Index()
        {
            return "Hello from HomeController!";
        }

        [HttpGet("hello")]  // shorthand for what was done above
        public string Hello()
        {
            return "Hi!";
        }

        [HttpGet("users/{username}/{user_id}")]  // route parameter can be string or int
        public string HelloUser(string username, int user_id)  // using route parameter
        {
            return $"Hello {username}! Your User ID is {user_id}."; 
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
        public ViewResult ReturnViewExample()  // notice return type
        {
            return View("Index");
            // if View() is left blank, it will automatically try to find a View with the method name ReturnViewExample
            // in both the Home and Shared folders inside the Views folder
        }

        // redirect to other controller methods rather than rendering a view:
        // (For example, when we handle a post request.)
        public RedirectToActionResult RedirectExample()
        {
            return RedirectToAction("ReturnViewExample");
        }

        // If the method you want to redirect to expects route parameters,
        // we pass an anonymous object as an additional argument:
        [HttpGet("redirect_test")]
        public RedirectToActionResult RedirectWithParams()
        {
            return RedirectToAction("HelloUser", new { username = "Taylor", user_id = 1001 });
            // The anonymous object consists of keys and values
            // The keys should match the parameter names of the method being redirected to
        }
    }
}