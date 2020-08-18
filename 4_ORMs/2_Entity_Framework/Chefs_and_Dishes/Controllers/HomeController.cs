using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chefs_and_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs_and_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db;
        public HomeController(MyContext context)
        {
        db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> chefs = db.Chefs.Include(chef => chef.CreatedDishes).ToList();
            return View("Index", chefs);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("NewChef");
        }

        [HttpPost("create_chef")]
        public IActionResult CreateChef(Chef newChef)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewChef");
            }

            if (newChef.DOB > DateTime.Today)
            {
                ModelState.AddModelError("DOB", "can't be future date");
                return View("NewChef");
            }

            int age = DateTime.Now.Year - newChef.DOB.Year;
            if (age < 18)
            {
                ModelState.AddModelError("DOB", "must be 18 or older");
                return View("NewChef");
            }

            db.Add(newChef);
            db.SaveChanges();
            ViewBag.Age = age;
            return RedirectToAction("Index");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> dishes = db.Dishes.Include(dish => dish.Creator).ToList();
            return View("Dishes", dishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            List<Chef> chefs = db.Chefs.ToList();
            ViewBag.Chefs = chefs;
            return View("NewDish");
        }

        [HttpPost("create_dish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewDish");
            }

            db.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Dishes");
        }
    }
}
