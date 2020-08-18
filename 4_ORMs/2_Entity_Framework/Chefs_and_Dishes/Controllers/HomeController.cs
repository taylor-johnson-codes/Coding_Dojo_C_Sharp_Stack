using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chefs_and_Dishes.Models;

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
            List<Dish> allDishes = db.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            return View("Index", allDishes);  
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            // validations check:
            if (ModelState.IsValid == false)
            {
                return View("New");
            }

            db.Dishes.Add(newDish);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        
        [HttpGet("{dishId}")]  // dishId is string in URL
        public IActionResult Details(int dishId)  // now it's an int
        {
            Dish selectedDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if (selectedDish == null)
            {
                return RedirectToAction("Index");
            }
            return View("Details", selectedDish);
        }

        [HttpPost("{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish selectedDish = db.Dishes.FirstOrDefault(p => p.DishId == dishId);

            if (selectedDish != null)
            {
                db.Dishes.Remove(selectedDish);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet("{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish selectedDish = db.Dishes.FirstOrDefault(p => p.DishId == dishId);

            if (selectedDish == null)
            {
                return RedirectToAction("Index");
            }
            return View("Edit", selectedDish);
        }

        [HttpPost("{dishId}/update")]
        public IActionResult Update(Dish editedDish, int dishId)
        {

            // validations check:
            if (ModelState.IsValid == false)
            {
                return View("Edit", editedDish);
            }

            Dish selectedDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if (selectedDish == null)
            {
                return RedirectToAction("Index");
            }

            // selectedDish.Chef = editedDish.Chef;
            // selectedDish.Name = editedDish.Name;
            // selectedDish.Calories = editedDish.Calories;
            // selectedDish.Tastiness = editedDish.Tastiness;
            // selectedDish.Description = editedDish.Description;
            // selectedDish.UpdatedAt = DateTime.Now;

            // db.Dishes.Update(selectedDish);
            // db.SaveChanges();

            return RedirectToAction("Details", new {dishId = dishId});
        }
    }
}
