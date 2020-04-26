using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GameBoard()
        {
            return View();
        }

        
        public IActionResult EnterPlayerData()
        {
            return View();
        }

    }
}