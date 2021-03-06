﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
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
            
            HttpContext.Session.SetInt32("userId", newUser.UserId);
            // HttpContext.Session.SetString("userName", newUser.FirstName);
            return RedirectToAction("Dashboard");
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

            HttpContext.Session.SetInt32("userId", dbUser.UserId);
            // HttpContext.Session.SetString("userName", dbUser.FirstName);
            return RedirectToAction("Dashboard");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // gets userId
        private int? userId { get { return HttpContext.Session.GetInt32("userId"); } }

        // gets boolean if user is logged in or not
        private bool isLoggedIn { get { return userId != null; } }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }

            List<Wedding> weddings = db.Weddings
                .Include(w => w.Attendees)
                .ThenInclude(a => a.Attendee)
                .ToList();
            return View("Dashboard", weddings);
        }

        [HttpGet("new_wedding")]
        public IActionResult NewWedding()
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }

            return View("NewWedding");
        }

        [HttpPost("new_wedding/create")]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewWedding");
            }

            if (newWedding.Date.Date <= DateTime.Now.Date)
            {
                ModelState.AddModelError("Date", "must be a future date");
                return View("NewWedding");
            }

            newWedding.UserId = (int)userId;
            db.Weddings.Add(newWedding);
            db.SaveChanges();

            List<Wedding> weddings = db.Weddings
                .Include(w => w.Attendees)
                .ToList();

            return RedirectToAction("Dashboard", weddings);
        }

        [HttpGet("wedding/{weddingId}")]
        public IActionResult Wedding(int weddingId)
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }

            Wedding wedding = db.Weddings
                .Include(w => w.Attendees)
                .ThenInclude(w => w.Attendee)
                .FirstOrDefault(w => w.WeddingId == weddingId); 

            return View("Wedding", wedding);
        }

        [HttpGet("wedding/delete/{weddingId}")]
        public IActionResult DeleteWedding(int weddingId)
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }

            Wedding deleteWedding = db.Weddings
            .FirstOrDefault(w => w.WeddingId == weddingId);

            db.Weddings.Remove(deleteWedding);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/rsvp/{weddingId}")]
        public IActionResult Rsvp(int weddingId, Rsvp newRsvp)
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }

            newRsvp.WeddingId = weddingId;
            newRsvp.UserId = (int)userId;
            db.Rsvps.Add(newRsvp);
            db.SaveChanges();

            return RedirectToAction("Wedding", weddingId);
        }

        [HttpGet("wedding/un-rsvp/{weddingId}")]
        public IActionResult unRsvp(int weddingId)
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }

            Rsvp removeRsvp = db.Rsvps.FirstOrDefault(r => r.UserId == userId);
            db.Rsvps.Remove(removeRsvp);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }
    }
}
