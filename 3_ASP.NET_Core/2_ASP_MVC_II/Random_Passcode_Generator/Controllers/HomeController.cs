using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Random_Passcode_Generator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Random random = new Random();
            string charOptions = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] charArray = new char[14];
            for (int i = 0; i < 14; i++)
            {
                charArray[i] = charOptions[random.Next(0, charOptions.Length)];
            }
            // alternate: string passcode = string.Join("", charArray);
            string passcode = new string(charArray);
            ViewBag.Code = passcode;

            Count();
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            return View("Index");
        }

        [HttpPost("generate")]
        public IActionResult Generate()
        {
            return RedirectToAction("Index");
        }

        public void Count()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            if(count == null)
            {
                count = 1;
            }
            else
            {
            count ++;
            }
            HttpContext.Session.SetInt32("Count", (int)count);  // key value pair
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}