using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        // Reference: Created DbContext - https://youtu.be/RwQVRXEs370?si=UntG9-TV410Z1qPE&t=2641
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Match> Matches => Set<Match>();
        public DbSet<PlayerMatchStat> PlayerMatchStats => Set<PlayerMatchStat>();
    }
}