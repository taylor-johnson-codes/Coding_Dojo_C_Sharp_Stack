using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Meals") == null)
            {
                NewGame();
            }

            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? meals = HttpContext.Session.GetInt32("Meals");

            if (happiness >= 100 && fullness >= 100 && energy >= 100)
            {
                HttpContext.Session.SetString("Message", "Congratulations! You Won!");
            }

            if (fullness == 0 || happiness == 0)
            {
                HttpContext.Session.SetString("Message", "You lose. Dojodachi is no longer with us.");
            }

            ViewBag.Happiness = happiness;
            ViewBag.Fullness = fullness;
            ViewBag.Energy = energy;
            ViewBag.Meals = meals;
            ViewBag.Message = HttpContext.Session.GetString("Message");
            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Meal = HttpContext.Session.GetInt32("Meals");
            
            if (Fullness >= 100)
            {
                HttpContext.Session.SetString("Message", "Dojodachi is very full right now.");
            }
            if (Meal <= 0)
            {
                HttpContext.Session.SetString("Message", "You have no meals to feed Dojodachi.");
            } 
            else
            {
                Random random = new Random();
                int i = random.Next(5,11);
                HttpContext.Session.SetInt32("Fullness", (int)Fullness + i);
                HttpContext.Session.SetInt32("Meals", (int)Meal - 1);
                HttpContext.Session.SetString("Message", "You feed Dojodachi! Fullness +" + i + ", meal - 1.");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            int? Energy = HttpContext.Session.GetInt32("Energy");

            if (Energy <= 0)
            {
                HttpContext.Session.SetString("Message", "Dojodachi has no energy to play.");
            }
            else
            {
                Random random = new Random();
                int i = random.Next(5,11);
                int j = random.Next(1,5);
                if (j != 4)
                {
                    HttpContext.Session.SetInt32("Happiness", (int)Happiness + i);
                    HttpContext.Session.SetInt32("Energy", (int)Energy - 5);
                    HttpContext.Session.SetString("Message", "Dojodachi played! Happiness +" + i + ", Energy - 5.");
                }
                else  // 25% chance pet doesn't want to play
                {
                    HttpContext.Session.SetInt32("Energy", (int)Energy - 5);
                    HttpContext.Session.SetString("Message", "Dojodachi doesn't want to play right now.");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            int? Meal = HttpContext.Session.GetInt32("Meals");
            int? Energy = HttpContext.Session.GetInt32("Energy");

            if(Energy <= 0)
            {
                HttpContext.Session.SetString("Message", "Dojodachi has no energy to work right now.");
            }
            else
            {
                Random random = new Random();
                int i = random.Next(1,4);
                HttpContext.Session.SetInt32("Energy", (int)Energy - 5);
                HttpContext.Session.SetInt32("Meals", (int)Meal + i);
                HttpContext.Session.SetString("Message", "Dojodachi went to work! Energy - 5 and Meal + " + i + ".");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            int? Fullness = HttpContext.Session.GetInt32("Fullness");

            HttpContext.Session.SetInt32("Energy", (int)Energy + 15);
            HttpContext.Session.SetInt32("Fullness", (int)Fullness - 5);
            HttpContext.Session.SetInt32("Happiness", (int)Happiness - 5);
            HttpContext.Session.SetString("Message", "Dojodachi went to sleep! Energy + 15, Happiness and Fullness - 5");
            return RedirectToAction("Index");
        }

        [HttpPost("new_game")]
        public IActionResult NewGame()
        {
            HttpContext.Session.Clear();
            Pet newPet = new Pet();
            HttpContext.Session.SetInt32("Happiness", newPet.Happiness);
            HttpContext.Session.SetInt32("Fullness", newPet.Fullness);
            HttpContext.Session.SetInt32("Energy", newPet.Energy);
            HttpContext.Session.SetInt32("Meals", newPet.Meals);
            string message = "This is Dojodachi!";
            HttpContext.Session.SetString("Message", message);
            return RedirectToAction("Index");
        }
    }
}