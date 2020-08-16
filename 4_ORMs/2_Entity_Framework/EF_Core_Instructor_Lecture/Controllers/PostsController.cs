// this could all be in the HomeController if you want
// Name it plural like the name of the DB table

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
    }
}