using Microsoft.EntityFrameworkCore;

namespace ADO.API.Models
{
	public class AdoDbContext : DbContext
    {
        public AdoDbContext(DbContextOptions<AdoDbContext> options) : base(options)
        {
        }
    }
}