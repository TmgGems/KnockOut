using Microsoft.EntityFrameworkCore;
using ProductCrudKnockOut.Models;

namespace ProductCrudKnockOut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
