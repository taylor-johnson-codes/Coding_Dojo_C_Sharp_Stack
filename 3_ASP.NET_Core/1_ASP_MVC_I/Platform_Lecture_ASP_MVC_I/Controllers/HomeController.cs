using Microsoft.AspNetCore.Mvc;  // provides Controller class that we inherit below

namespace Platform_Lecture_ASP_MVC_I
{
    public class HomeController : Controller  
    // the name given before Controller (Home) is the name of the Views folder for this Controller
    {
        // Request:
        [Route("")]  // localhost:5000
        [HttpGet]  // get requests are implicitly there in the background if it's not explicit like this

        // Response:
        public string Index()
        {
            return "Hello from HomeController!";
        }

        // Request:
        [Route("hello")]  // localhost:5000/hello
        [HttpGet]

        // Response:
        public string Hello()
        {
            return "Hi!";
        }

    }
}