using Microsoft.EntityFrameworkCore;

namespace ADO.API.Models
{
	public class AdoDbContext : DbContext
    {
        public AdoDbContext(DbContextOptions<AdoDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = null!;
        public DbSet<Order> Order { get; set; } = null!;
    }
}