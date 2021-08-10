using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ECContext : DbContext
    {
        public ECContext(DbContextOptions<ECContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
