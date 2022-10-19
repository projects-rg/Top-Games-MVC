using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GamesMVC.Models;

using UWS.Shared;


namespace GamesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GamesDB db;

        public HomeController(ILogger<HomeController> logger, GamesDB injectedContext)
        {
            _logger = logger;
            db=injectedContext;
        }

        public IActionResult Index()
        {
           var model = new HomeIndexViewModel
            {
                VisitorCount = (new Random()).Next(1, 1001),
                Categories = db.Categories.ToList(),
                Games = db.Games.ToList()
            };

            return View(model); // pass model to view
        }

        public IActionResult GamesDetail(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound("You must pass a Game ID in the route, for example, /Home/GamesDetail/21");
            }
            var model = db.Games
              .SingleOrDefault(p => p.GameID == id);
            if (model == null)
            {
                return NotFound($"Game with ID of {id} not found.");
            }
            return View(model); // pass model to view and then return result
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
