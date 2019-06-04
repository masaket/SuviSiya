using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuviSiya.Models;

namespace SuviSiya.Controllers
{
    public class GamesController : Controller
    {

        // GET: Games/Random
        public ViewResult Random()
        {
            var games = new Games() { Name = "Snake!" };
            return View(games);
           
        }
    }
}