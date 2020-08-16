// this could all be in the HomeController if you want
// Name it plural like the name of the DB table

using System.Collections.Generic;
using System.Linq;
using EF_Core_Instructor_Lecture.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Instructor_Lecture.Controllers
{
    public class PostsController : Controller
    {
        private MyContext db;
        
        public PostsController(MyContext context)
        {
            db = context;
        }

        [HttpGet("/posts")]
        public IActionResult All()
        {
            List<Post> allPosts = db.Posts.ToList();
            return View("All", allPosts);  
            // sending over allPosts as a model instead of thru ViewBag
        }

        [HttpGet("/posts/new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("/posts/create")]
        public IActionResult Create(Post newPost)
        {
            // validations check:
            if (ModelState.IsValid == false)
            {
                return View("New");
            }

            db.Posts.Add(newPost);
            db.SaveChanges();

            return RedirectToAction("All");
        }
    }
}