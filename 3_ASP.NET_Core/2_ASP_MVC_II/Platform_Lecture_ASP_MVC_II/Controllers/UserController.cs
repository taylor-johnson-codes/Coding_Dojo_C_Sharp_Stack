using System;
using Microsoft.AspNetCore.Mvc;
using Platform_Lecture_ASP_MVC_II.Models;
using Microsoft.AspNetCore.Http;  // added for session; also added 2 lines for session in StartUp.cs

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
        including any errors found. Its IsValid property will return a boolean -- true if no errors were found, 
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


        [HttpGet("test_nav_partial")]
        public IActionResult TestNavPartial()
        {
            ViewBag.CurrentTime = DateTime.Now;
            ViewBag.Message = "The Time is:";
            return View();
        }
    }
}

/*
Session:
Session can only hold integers and strings.
To store a string in session we use ".SetString"
The first string passed is the key and the second is the value we want to retrieve later

    HttpContext.Session.SetString("UserName", "Samantha");

To retrieve a string from session we use ".GetString"

    string LocalVariable = HttpContext.Session.GetString("UserName");

To store an int in session we use ".SetInt32"

    HttpContext.Session.SetInt32("UserAge", 28);

To retrieve an int from session we use ".GetInt32"

    int? IntVariable = HttpContext.Session.GetInt32("UserAge");

You may have noticed that when retrieving an int from session we have to store it in an int? variable, 
rather than an int. This is because int variables are non-nullable; any given session variable could 
contain a null value, so we have to use the nullable-int type int?.

We can clear our session with the Clear method:

    HttpContext.Session.Clear();

To pass values stored in session to your view, we will use either ViewBag or a View Model to give your 
views access to session data. As an example, let's say you are tracking clicks of a button and storing 
a "count" value in session.  

    In your Controller:
    ViewBag.Count = HttpContext.Session.GetInt32("count");

    In your View:
    <h2>You have clicked the button @ViewBag.Count</h2>

Temp Data:
Sometimes we want to hold onto simple data through a redirect, but not persist as long as session 
(think simple error messages). TempData does just that--it is like a temporary session that only persists 
across one redirect. We can store strings or ints in TempData and we don't have to worry about that data 
sticking around and taking up space. TempData is built on top of session, though, so we cannot use it 
without enabling session in our application.

    public IActionResult Method()
    {
        TempData["Variable"] = "Hello World";
        return RedirectToAction("OtherMethod");
    }
    public IActionResult OtherMethod()
    {
        Console.WriteLine(TempData["Variable"]);
        // writes "Hello World" if redirected to from Method()
    }
*/