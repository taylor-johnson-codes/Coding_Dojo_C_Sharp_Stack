using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bank_Accounts.Models;

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
            return View();
        }

    }
}
