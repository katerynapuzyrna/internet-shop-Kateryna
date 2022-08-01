//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace AppContext
{
    public class ApplicationContextMain : DbContext
    {
        public ApplicationContextMain()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        //services.AddDbContext<AspDbContext>(options =>
        // options.UseSqlServer(config.GetConnectionString("optimumDB")));

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