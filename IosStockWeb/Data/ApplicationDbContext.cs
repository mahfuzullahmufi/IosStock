using IosStockWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace IosStockWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }



        public DbSet<Category> Categories { get; set; }
    }
}
