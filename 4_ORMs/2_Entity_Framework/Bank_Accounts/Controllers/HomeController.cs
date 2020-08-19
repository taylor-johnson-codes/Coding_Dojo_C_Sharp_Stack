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
            
            HttpContext.Session.SetInt32("user_id", newUser.UserId);
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

            HttpContext.Session.SetInt32("user_id", dbUser.UserId);
            HttpContext.Session.SetString("UserName", dbUser.FirstName);
            return RedirectToAction("Account_Page");
        }

        [HttpGet("account")]
        public IActionResult Account_Page()
        {
            // if user not logged in, returns user to login/reg page:
            // if(HttpContext.Session.GetInt32("user_id") == null)
            // {
            //     return RedirectToAction("Index");
            // }

            int? user_id = HttpContext.Session.GetInt32("user_id");
            User dbUser = db.Users.FirstOrDefault(user => user.UserId == (int)user_id);
            HttpContext.Session.SetString("FirstName", dbUser.FirstName);
            HttpContext.Session.SetString("LastName", dbUser.LastName);

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
            ViewBag.Transaction_List = transactions;
            return View("Account_Page");
        }

        [HttpPost("transaction")]
        public IActionResult User_Transaction(Transaction trans)
        {
            // if (trans.Amount > ViewBag.Total)
            // {
            //     ModelState.AddModelError("low_bal", "can't withdraw more than your total account balance");
            // }

            if (ModelState.IsValid == false)
            {
                return View("Account");
            }

            int? user_id = HttpContext.Session.GetInt32("user_id");
            trans.UserId = (int)user_id;
            db.Add(trans);
            db.SaveChanges();
            return RedirectToAction("Account_Page");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
