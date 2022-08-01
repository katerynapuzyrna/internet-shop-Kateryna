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
    public class ShopController : Controller
{
        private ILogger<ShopController> logger;
        public ShopController(ILogger<ShopController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Shop Controller Index called");
            return View();
        }
        public IActionResult Error()
        {
            logger.LogWarning("Shop Controller Error called");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public new IActionResult View()
        {
            logger.LogInformation("Shop Controller View called");

            using (ApplicationContext db = new ApplicationContext())
            {
                var shop = new ShopModel() { City = "Kyiv", Address = "Shevchenka str.", ContactPhone = "+380505628596" };
                var shop2 = new ShopModel() { City = "Lviv", Address = "Bandery str.", ContactPhone = "+380505628595" };
                db.Shop.Add(shop);
                db.Shop.Add(shop2);
                db.SaveChanges();
                var shoplist = db.Shop.ToList();
                return View(shoplist);
            }
        }
    }
}
