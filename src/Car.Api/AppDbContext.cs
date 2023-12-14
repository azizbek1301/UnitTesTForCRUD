using Car.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car.Api
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
           => Database.Migrate();

        public DbSet<Mashina> Cars { get; set; }
    }
}
