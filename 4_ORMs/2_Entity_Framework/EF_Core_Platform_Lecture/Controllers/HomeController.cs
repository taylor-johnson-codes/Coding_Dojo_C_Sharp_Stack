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
        }

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
                User RetrievedUser = db.Users.FirstOrDefault(user => user.UserId == userId);
                // Then we may modify properties of this tracked model object
                RetrievedUser.Name = "New name";
                RetrievedUser.UpdatedAt = DateTime.Now;
                
                // Finally, .SaveChanges() will update the DB with these new values
                db.SaveChanges();
                
                // Other code
            }
            */


            /*
            REMOVE EXAMPLE:

            [HttpGet("delete/{userId}")]
            public IActionResult DeleteUser(int userId)
            {
                // Like Update, we will need to query for a single user from our Context object
                User RetrievedUser = db.Users.SingleOrDefault(user => user.UserId == userId);
                
                // Then pass the object we queried for to .Remove() on Users
                db.Users.Remove(RetrievedUser);
                
                // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
                db.SaveChanges();
                // Other code
            }
            */


            /*
            UNIQUE FIELD i.e. email address can only be registered once:

            [HttpPost("register")]
            public IActionResult Register(User user)
            {
                // Check initial ModelState
                if(ModelState.IsValid)
                {
                    // If a User exists with provided email
                    if(db.Users.Any(u => u.Email == user.Email))
                    {
                        // Manually add a ModelState error to the Email field, with provided
                        // error message
                        ModelState.AddModelError("Email", "Email already in use!");
                        
                        // You may consider returning to the View at this point
                    }
                }
                // other code
            } 
            */


            /*
            HASHING PASSWORD:
            
            using Microsoft.AspNetCore.Identity;

            namespace YourNamespace.Controllers
            {
                public class YourController : Controller
                {
                    //Route
                    public IActionResult Method(User user)
                    {
                        if(ModelState.IsValid)
                        {
                            // Initializing a PasswordHasher object, providing our User class as its type
                            PasswordHasher<User> Hasher = new PasswordHasher<User>();
                            user.Password = Hasher.HashPassword(user, user.Password);
                            //Save your user object to the database
                        }
                    }
                }
            }
            */


            /*
            LOG IN:

            using Microsoft.AspNetCore.Identity;

            namespace YourNamespace.Controllers
            {
                public IActionResult Login(LoginUser userSubmission)
                {
                    if(ModelState.IsValid)
                    {
                        // If inital ModelState is valid, query for a user with provided email
                        var userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                        // If no user exists with provided email
                        if(userInDb == null)
                        {
                            // Add an error to ModelState and return to View!
                            ModelState.AddModelError("Email", "Invalid Email/Password");
                            return View("SomeView");
                        }
                        
                        // Initialize hasher object
                        var hasher = new PasswordHasher<LoginUser>();
                        
                        // verify provided password against hash stored in db
                        var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                        
                        // result can be compared to 0 for failure
                        if(result == 0)
                        {
                            // handle failure (this should be similar to how "existing email" is handled)
                        }
                    }
                }
            }
            */



        // ONE TO MANY RELATIONSHIPS:

        public IActionResult Index2()
        {
            List<Message> messagesWithUser = db.Messages
                // populates each Message with its related User object (Creator)
                .Include(message => message.Creator)
                .ToList();
            
            return View("Index2", messagesWithUser);
        }

        [HttpGet("{userId}")]    
        public IActionResult UserDetails(int userId)
        {
            // Number of messages created by this User:
            int numMessages = db.Users
                // Including Messages, so that we may query on this field
                .Include(user => user.CreatedMessages)
                // Get a User with userId
                .FirstOrDefault(user => user.UserId == userId)
                // Now, with a reference to a User object, and access to a User's Messages
                // We can get the .Count property of the Messages List
                .CreatedMessages.Count;
             
            // User with the longest Message, we can do this in two stages
            // First, find the Length of the longest Message
            int longestMessageLength = db.Messages.Max(message => message.Content.Length);
            // Second, select one User who's CreatedMessages has Any that matches this character count
            // Note here that CreatedMessages is a List, and thus can take a LINQ expression: such as .Any()
            User userWithLongest = db.Users
                .Include(user => user.CreatedMessages)
                .FirstOrDefault(user => user.CreatedMessages
                    .Any(message => message.Content.Length == longestMessageLength));
             
            // Messages NOT related to this User:
            // Since this query only requires checking a Message's UserId
            // and doesn't require us to check data contained in a Message's Creator
            // We can do this without a .Include()
            List<Message> unrelatedMessages = db.Messages
                .Where(message => message.UserId != userId)
                .ToList();
             
            return View();
        }


        // MANY TO MANY:
        [HttpGet("{personId}")]
        public IActionResult Show(int personId)
        {
            var personWithSubsAndMags = db.M2M_Persons
                .Include(person => person.M2M_Subscriptions)
                .ThenInclude(sub => sub.M2M_Magazine)
                .FirstOrDefault(person => person.M2M_PersonId == personId);
            
            return View(personWithSubsAndMags);
        }
    }
}
