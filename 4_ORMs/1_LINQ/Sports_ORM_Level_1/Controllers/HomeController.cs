using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            // ...all teams in the Atlantic Soccer Conference
            ViewBag.AllASCTeams = _context.Teams
            .Include(t => t.CurrLeague)
            .Where(t => t.CurrLeague.Name.Contains("Atlantic Soccer Conference"))
            .ToList();

            // ...all (current) players on the Boston Penguins (Hint: Boston is the Location, Penguins is the TeamName)
            ViewBag.PengPlayers = _context.Players
            .Include(p => p.CurrentTeam)
            .Where(p => p.CurrentTeam.Location.Contains("Boston") && p.CurrentTeam.TeamName.Contains("Penguins"))
            .ToList();

            // ...all (current) players in the International Collegiate Baseball Conference
            ViewBag.ICBCplayers = _context.Players
            .Include(p => p.CurrentTeam.CurrLeague)
            .Where(p => p.CurrentTeam.CurrLeague.Name.Contains("International Collegiate Baseball Conference"))
            .ToList();

            // ...all (current) players in the American Conference of Amateur Football with last name "Lopez"
            ViewBag.ACAFlopez = _context.Players
            .Include(p => p.CurrentTeam.CurrLeague)
            .Where(p => p.CurrentTeam.CurrLeague.Name.Contains("American Conference of Amateur Football") && p.LastName.Contains("Lopez"))
            .ToList();

            // ...all football players
            ViewBag.FBplayers = _context.Players
            .Include(p => p.CurrentTeam.CurrLeague)
            .Where(p => p.CurrentTeam.CurrLeague.Sport.Contains("Football"))
            .ToList();

            // ...all teams with a (current) player named "Sophia"
            ViewBag.Sophia = _context.Players
            .Where(p => p.FirstName.Contains("Sophia"))
            .Include(p => p.CurrentTeam)
            .ToList();

            // ...all leagues with a (current) player named "Sophia"
            ViewBag.SophiaLeague =_context.Players
            .Where(p => p.FirstName.Contains("Sophia"))
            .Include(p => p.CurrentTeam.CurrLeague)
            .ToList();

            // ...everyone with the last name "Flores" who DOESN'T (currently) play for the Washington Roughriders
            ViewBag.Flores = _context.Players
            .Include(p => p.CurrentTeam.CurrLeague)
            .Where(p => !p.CurrentTeam.CurrLeague.Name.Contains("Washington Roughriders") && p.LastName.Contains("Flores"))
            .ToList();

            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            // <li>...all teams, past and present, that Samuel Evans has played with</li>
            var SE = _context.Players
                .FirstOrDefault(p => p.FirstName == "Samuel" && p.LastName == "Evans");
            ViewBag.FirstName = SE.FirstName;
            ViewBag.LastName = SE.LastName;

            var SEteams = _context.PlayerTeams
                .Where(id => id.PlayerId == SE.PlayerId)
                .ToList();

            return View("Level3", SEteams);

            // <li>...all players, past and present, with the Manitoba Tiger-Cats</li>

            // <li>...all players who were formerly (but aren't currently) with the Wichita Vikings</li>

            // <li>...every team that Jacob Gray played for before he joined the Oregon Colts</li>

            // <li>...everyone named "Joshua" who has ever played in the Atlantic Federation of Amateur Baseball Players</li>

            // <li>...all teams that have had 12 or more players, past and present.</li>

            // <li>...all players, sorted by the number of teams they've played for</li>

            // return View();
        }
    }
}