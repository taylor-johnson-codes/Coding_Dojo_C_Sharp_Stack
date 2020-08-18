using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bank_Accounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Bank_Accounts.Controllers
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
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(db.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already registered!");
                }
            }

            if(ModelState.IsValid == false)
            {
                return View("Index");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();
            
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("UserName", newUser.FirstName);
            return RedirectToAction("Account_Page");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser loginUser)
        {
            string genericErrorMsg = "Invalid email or password!";

            if(ModelState.IsValid == false)
            {
                return View("Index");
            }

            User dbUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);

            if(dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", genericErrorMsg);
                return View("Index");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
            
            if(pwCompareResult == 0)  // 0 means password entered doesn't match password in DB
            {
                ModelState.AddModelError("LoginEmail", genericErrorMsg);
                return View("Index");
            }

            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("UserName", dbUser.FirstName);
            return RedirectToAction("Account_Page");
        }

        [HttpGet("account/{user_id}")]
        public IActionResult Account_Page(int user_id)
        {
            // if user not logged in, returns user to login/reg page:
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }

            User currentUser = db.Users.FirstOrDefault(user => user.UserId == (int)user_id);
            HttpContext.Session.SetString("FirstName", dbUser.FirstName);
            

            List<Transaction> transactions = db.Transactions
                .Where(t => t.UserId == (int)user_id)
                .OrderByDescending(t => t.CreatedAt)
                .ToList();

            decimal? total = db.Transactions
                .Where(t => t.UserId == (int)user_id)
                .Sum(t => t.Amount);
            if (total == null)
            {
                total = 0;
            }
            ViewBag.Total = (decimal)total;
            return View("Account", transactions);
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
