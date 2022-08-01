//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using MVC_Kateryna.Models;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        //services.AddDbContext<AspDbContext>(options =>
        // options.UseSqlServer(config.GetConnectionString("optimumDB")));
        public DbSet<ShopModel> Shop { get; set; } = null!;
        public DbSet<CartModel> Cart { get; set; } = null!;
        public DbSet<GameModel> Game { get; set; } = null!;
        public DbSet<UserModel> User { get; set; } = null!;
        public DbSet<AccessoryModel> Accessory { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"data source=(LocalDb)\MSSQLLocalDB;Initial Catalog=boardgamestore;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(modelBuilder: builder);
        }
    }
}