namespace VideogameStatsApi.Models
{
    // Reference: Created Player model - https://youtu.be/RwQVRXEs370?si=O8ug9L7xNQpgcCkE&t=853
    // Represents a Player
    public class Player
    {
        // Primary Key for the Player Table
        public int Id { get; set; }
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
        // Each Player can have stats in many Matches
        public ICollection<PlayerMatchStat> PlayerMatchStats { get; set; } = new List<PlayerMatchStat>();
    }
}