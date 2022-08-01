using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Kateryna.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Kateryna.Controllers
{
    public class CartController : Controller
{
        private ILogger<CartController> logger;
        public CartController(ILogger<CartController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Cart Controller Index called");
            return View();
        }
        public IActionResult Error()
        {
            logger.LogWarning("Cart Controller Error called");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public new IActionResult View()
        {
            logger.LogInformation("Cart Controller View called");

            using (ApplicationContext db = new ApplicationContext())
            {
                var cart = new CartModel() { Name = "Gloomhaven", Price = 300};
                db.Cart.Add(cart);
                db.SaveChanges();
                var cartlist = db.Cart.ToList();
                return View(cartlist);
            }
        }
}
}
