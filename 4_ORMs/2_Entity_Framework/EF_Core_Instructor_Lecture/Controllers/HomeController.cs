﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF_Core_Instructor_Lecture.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Instructor_Lecture.Controllers
{
    public class HomeController : Controller
    {
        // for less code in all the methods:
        // gets user_id
        private int? user_id { get {return HttpContext.Session.GetInt32("UserId");} }

        // gets boolean if user is logged in or not
        private bool isLoggedIn { get {return user_id != null;} }

        // need this db code/constructor in every Controller
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
            // Check initial ModelState
            if(ModelState.IsValid)
            {
                // If a User exists with provided email
                if(db.Users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided error message
                    ModelState.AddModelError("Email", "Email already registered!");  // key is which model field to add the error to
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
            
            // logging the user in:
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("UserName", newUser.FirstName);
            // redirecting to another controller:
            return RedirectToAction("All", "Posts");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser loginUser)
        {
            string genericErrorMsg = "Invalid email or password!";  // don't want tell user/hacker exactly what was wrong

            if(ModelState.IsValid == false)
            {
                return View("Index");
            }

            User dbUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);

            if(dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", genericErrorMsg);
                // ModelState.AddModelError("LoginEmail", "Email not registered!");
                return View("Index");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
            
            // 0 means password entered doesn't match password in DB; 1 means it matched
            if(pwCompareResult == 0)
            {
                ModelState.AddModelError("LoginEmail", genericErrorMsg);
                // ModelState.AddModelError("LoginEmail", "Wrong password!");
                return View("Index");
            }

            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("UserName", dbUser.FirstName);
            // redirecting to another controller:
            return RedirectToAction("All", "Posts");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        /*
        Don't want logout to be an a-tag because Chrome preloads a-tag links to make tags faster when you click them.
        Don't want that feature to log the user out automatically.
        */

        [HttpGet("users/{user_id}")]
        public IActionResult AuthorPage(int user_id)
        {
            // if user not logged in, returns user to login/reg page:
            if(!isLoggedIn)  // LONGHAND, w/o code above db code: if(HttpContext.Session.GetInt32("user_id") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            User user = db.Users.Include(u => u.Posts).FirstOrDefault(u => u.UserId == user_id);

            if(user == null)
            {
                return RedirectToAction("All", "Posts");
            }

            return View("AuthorPage", user);
        }
    }
}
