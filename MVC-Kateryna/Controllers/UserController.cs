using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Kateryna.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MVC_Kateryna.Controllers
{
    public class UserController : Controller
{
        private ILogger<UserController> logger;
        public UserController(ILogger<UserController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("User Controller Index called");
            return View();
        }
        public IActionResult Error()
        {
            logger.LogWarning("User Controller Error called");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public new IActionResult View()
        {
            logger.LogInformation("User Controller View called");
            return View(new List<UserModel> {
                new UserModel {
                    FirstName = "Kateryna",
                    LastName = "Pushko",
                    Email = "kateryna.puzyrna@gmail.com"
            },
                 new UserModel {
                    FirstName = "Anna",
                    LastName = "Shevchenko",
                    Email = "testemail@gmail.com"
            }
            });
        }
    }
}
