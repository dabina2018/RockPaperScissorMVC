using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GameBoard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterPlayerData()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult EnterPlayerData(PlayerModel player)
        {
            if (ModelState.IsValid)
            {
                // PlayerModel lastPlayer = _data.ButterfliesList.LastOrDefault();
                //player.playerId = lastPlayer.playerId + 1;   
                //player.playerName = set equal to text field
                //player.playerEmail = set equal to text field
                               
            }
            return View(player);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
