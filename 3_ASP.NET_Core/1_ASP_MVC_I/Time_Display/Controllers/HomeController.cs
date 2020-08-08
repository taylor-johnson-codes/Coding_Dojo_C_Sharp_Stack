using System;
using Microsoft.AspNetCore.Mvc;

namespace Time_Display.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime currentTime = DateTime.Now;
            ViewBag.Date = currentTime.ToString("MMM dd, yyyy");
            ViewBag.Time = currentTime.ToString("hh:mm tt");
            return View();
        }
    }
}