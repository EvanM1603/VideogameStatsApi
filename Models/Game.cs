namespace VideogameStatsApi.Models
{
    // Represents a Game
    public class Game
    {
        // Primary Key for the Game Table
        public int Id { get; set; }
        // The Name of the Game
        public string Name { get; set; } = string.Empty;
        // Each Game can have many Matches
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}