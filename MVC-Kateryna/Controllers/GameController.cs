using AppContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Kateryna.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Kateryna.Controllers
{
    public class GameController : Controller
{
        private ILogger<GameController> logger;
        public GameController(ILogger<GameController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
    {
            logger.LogInformation("Game Controller Index called");
            return View();
    }
        public IActionResult Error()
        {
            logger.LogWarning("Cart Controller Error called");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public new IActionResult View()
    {
            logger.LogInformation("Game Controller View called");


            using (ApplicationContext db = new ApplicationContext())
            {
                var game = new GameModel() { Name = "Gloomhaven", Price = 300, GameType = "Cooperative" };
                var game2 = new GameModel() { Name = "Carcassonne", Price = 50, GameType = "Family" };
                var game3 = new GameModel() { Name = "Twilight Imperium", Price = 100, GameType = "Strategy" };
                db.Game.Add(game);
                db.Game.Add(game2);
                db.Game.Add(game3);
                db.SaveChanges();
                var gamelist = db.Game.ToList();
                return View(gamelist);
            }
        }


    }
}
