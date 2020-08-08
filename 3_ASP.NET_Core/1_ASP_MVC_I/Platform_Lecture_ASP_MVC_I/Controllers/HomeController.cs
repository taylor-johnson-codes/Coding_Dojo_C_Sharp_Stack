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


        /*
        Redirecting to another Controller's method:
        return RedirectToAction("OtherMethodName", "OtherControllerName");  leave off Controller part of Controller name
        We can also pass arguments when redirecting to a different controller; simply add an anonymous object 
        as a third argument to the RedirectToAction method.
        */


        /*
        All the return data types we used above inherit from IActionResult, so all the return types above
        could be changed to IActionResult. This is useful if the return data types could be different based
        on an if/else statement.
        */


        // Return Json example:
        [HttpGet("json_example/{username}/{location}")]
        public JsonResult JsonExample(string username, string location)
        {
            var response = new{user=username,place=location};
            return Json(response);
        }


        // ViewBag example:
        [HttpGet("viewbag_example")]
        public IActionResult ViewBagExample()
        {
            // Here we assign the value "Hello World!" to the property .Example
            // Property names are arbitrary and can be whatever you like
            ViewBag.Example1 = "Hello World!";
            ViewBag.Example2 = 2020;
            ViewBag.Example3 = true;
            return View("Index");
        }

        /*
        One way we can send data from our controllers to our views is with an object called ViewBag. 
        ViewBag is a dictionary that only persists over one view return, and does not persist across redirects, 
        so it must be set in the method rendering the view we're sending data to. To use ViewBag, we define 
        properties and assign values to them.
        */


        // POST example:
        [HttpPost("method")]
        public IActionResult PostMethod(string my_text, int my_num)
        {
            // Do something with form input
        }

    }
}