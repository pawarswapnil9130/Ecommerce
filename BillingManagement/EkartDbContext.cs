using Ekart.Models;
using Microsoft.EntityFrameworkCore;

namespace Ekart
{
    public class EkartDbContext : DbContext
    {
        public DbSet<Products> ?Products { get; set; }


        public EkartDbContext(DbContextOptions<EkartDbContext> options) : base(options)
        {
        }
    }
}
