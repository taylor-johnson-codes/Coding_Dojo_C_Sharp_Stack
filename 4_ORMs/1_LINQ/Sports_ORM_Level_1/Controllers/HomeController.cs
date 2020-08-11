using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;

namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // In general your queries will look like this:
            // ViewBag.<Name of bag> = context.<Name of table>.<Your query goes here> 

            // <li>...all womens' leagues</li>
            ViewBag.WomensLeagues = _context.Leagues
                .Where(wl => wl.Name.Contains("Women"))
                .ToList();

            // <li>...all leagues where sport is any type of hockey</li>
            ViewBag.Hockey = _context.Leagues
                .Where(h => h.Sport.Contains("Hockey"))
                .ToList();

            // <li>...all leagues where sport is something OTHER THAN football</li>
            ViewBag.NotFootball = _context.Leagues
                .Where(nf => !nf.Sport.Contains("Football"))
                .ToList();

            // <li>...all leagues that call themselves "conferences"</li>
            ViewBag.Conferences = _context.Leagues
                .Where(c => c.Name.Contains("Conference"))
                .ToList();

            // <li>...all leagues in the Atlantic region</li>
            ViewBag.Atlantic = _context.Leagues
                .Where(a => a.Name.Contains("Atlantic"))
                .ToList();

            // <li>...all teams based in Dallas</li>
            ViewBag.Dallas = _context.Teams
                .Where(d => d.Location.Contains("Dallas"))
                .ToList();

            // <li>...all teams named the Raptors</li>
            ViewBag.Raptors = _context.Teams
                .Where(r => r.TeamName.Contains("Raptors"))
                .ToList();

            // <li>...all teams whose location includes "City"</li>
            ViewBag.City = _context.Teams
                .Where(c => c.Location.Contains("City"))
                .ToList();

            // <li>...all teams whose names begin with "T"</li>
            ViewBag.T = _context.Teams
                .Where(t => t.TeamName.Contains("T"))
                .ToList();

            // <li>...all teams, ordered alphabetically by location</li>
            ViewBag.LocationOrder = _context.Teams
                .OrderBy(lo => lo.Location)
                .ToList();

            // <li>...all teams, ordered by team name in reverse alphabetical order</li>
            ViewBag.RevTeamName = _context.Teams
                .OrderByDescending(rtn => rtn.TeamName)
                .ToList();

            // <li>...every player with last name "Cooper"</li>
            ViewBag.Cooper = _context.Players
                .Where(coop => coop.LastName.Contains("Cooper"))
                .ToList();

            // <li>...every player with first name "Joshua"</li>
            ViewBag.Joshua = _context.Players
                .Where(josh => josh.FirstName.Contains("Joshua"))
                .ToList();

            // <li>...every player with last name "Cooper" EXCEPT those with "Joshua" as the first name</li>
            ViewBag.CoopNotJosh = _context.Players
                .Where(cnj => cnj.LastName.Contains("Cooper") && !cnj.FirstName.Contains("Joshua"))
                .ToList();

            // <li>...all players with first name "Alexander" OR first name "Wyatt"</li>
            ViewBag.AlexOrWyatt = _context.Players
                .Where(aow => aow.FirstName.Contains("Alexander") || aow.FirstName.Contains("Wyatt"))
                .OrderBy(aow => aow.FirstName)
                .ThenBy(aow => aow.LastName)
                .ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }
    }
}