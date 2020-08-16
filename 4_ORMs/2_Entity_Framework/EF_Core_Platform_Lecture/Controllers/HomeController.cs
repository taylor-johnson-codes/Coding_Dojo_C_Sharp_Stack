using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;  // added this
// using Monsters.Models;  // added this
using System.Linq;  // added this
using EF_Core_Platform_Lecture.Models;  // added this

namespace EF_Core_Platform_Lecture.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // List<Monster> AllMonsters = _context.Monsters.ToList();
            return View();
        }
    }
}