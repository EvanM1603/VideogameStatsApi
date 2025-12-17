namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // The DTO returned when reading Match Data
    public class MatchResponse
    {
        // The ID of the Match
        public int Id { get; set; }
        // The ID of the Game the Match was played on
        public int GameId { get; set; }
        // The Map the Match was played on
        public string Map { get; set; } = string.Empty;
        // The Result of the Match
        public string Result { get; set; } = string.Empty;
    }
}