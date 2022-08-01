using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Kateryna.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MVC_Kateryna.Controllers
{
    public class AccessoryController : Controller
{
        private ILogger<AccessoryController> logger;
        public AccessoryController(ILogger<AccessoryController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Accessory Controller Index called");
            return View();
        }
        public IActionResult Error()
        {
            logger.LogWarning("Accessory Controller Error called");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public new IActionResult View()
        {
            logger.LogInformation("Accessory Controller View called");
            return View(new List<AccessoryModel> {
                new AccessoryModel {
                    Name = "Organizer",
                    Price = 40,
            },
               new AccessoryModel {
                    Name = "Card protectors",
                    Price = 5,
            }
            });
        }
    }
}
