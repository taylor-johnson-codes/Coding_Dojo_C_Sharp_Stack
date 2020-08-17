using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF_Core_Platform_Lecture.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Platform_Lecture.Controllers
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
            // Get all Monsters
            List<Monster> AllMonsters = db.Monsters.ToList();

            // Get first Monster
            Monster firstMonster = db.Monsters.FirstOrDefault(i => i.MonsterId == 1);

    		// Get the 5 most recently added Monsters
            List<Monster> MostRecent = db.Monsters
                .OrderByDescending(u => u.CreatedAt)
                .Take(5)
                .ToList();
			return View();
		
        	// Get Monsters with the LastName "Jefferson"
            // not sure why this is giving an error:
            // List<Monster> Jeffersons = db.Monsters.Where(u => u.Name == "Jefferson");

            /*
            CREATE EXAMPLE:

            [HttpPost("create")]
            public IActionResult CreateMonster(Monster newMonster)
            {
                // We can take the Monster object created from a form submission & use the .Add() method
                db.Add(newMonster);
                // OR db.Monsters.Add(newMonster);
                db.SaveChanges();
                // Other code
            }
            */


            /*
            EDIT/UPDATE EXAMPLE:

            [HttpGet("update/{userId}")]
            public IActionResult UpdateUser(int userId)
            {
                // We must first Query for a single User from our Context object to track changes.
                User RetrievedUser = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
                // Then we may modify properties of this tracked model object
                RetrievedUser.Name = "New name";
                RetrievedUser.UpdatedAt = DateTime.Now;
                
                // Finally, .SaveChanges() will update the DB with these new values
                dbContext.SaveChanges();
                
                // Other code
            }
            */


            /*
            REMOVE EXAMPLE:

            [HttpGet("delete/{userId}")]
            public IActionResult DeleteUser(int userId)
            {
                // Like Update, we will need to query for a single user from our Context object
                User RetrievedUser = dbContext.Users.SingleOrDefault(user => user.UserId == userId);
                
                // Then pass the object we queried for to .Remove() on Users
                dbContext.Users.Remove(RetrievedUser);
                
                // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
                dbContext.SaveChanges();
                // Other code
            }
            */
        }



        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }

    }
}
