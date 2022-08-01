//using System.Data.Entity;
using static System.AppContext;
using Microsoft.EntityFrameworkCore;
using MVC_Kateryna.Models;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace MVC_Kateryna
{
    public class ApplicationContext : AppContext.ApplicationContextMain
    {
        public DbSet<ShopModel> Shop { get; set; } = null!;
        public DbSet<CartModel> Cart { get; set; } = null!;
        public DbSet<GameModel> Game { get; set; } = null!;
        public DbSet<UserModel> User { get; set; } = null!;
        public DbSet<AccessoryModel> Accessory { get; set; } = null!;
    }
}