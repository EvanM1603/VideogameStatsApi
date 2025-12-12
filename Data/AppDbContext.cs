using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Game> Games => Set<Game>();
    }
}