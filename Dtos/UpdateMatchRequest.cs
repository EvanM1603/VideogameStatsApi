namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // DTO used to update an existing Match
    public class UpdateMatchRequest
    {
        // The ID of the Match
        public int MatchId { get; set; }
        // The ID of the Game the Match was played on
        public string Map { get; set; } = string.Empty;
        // The Result of the Match
        public string Result { get; set; } = string.Empty;
    }
}