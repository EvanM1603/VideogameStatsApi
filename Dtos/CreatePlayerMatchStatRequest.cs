namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // DTO used to create a new Match
    public class CreatePlayerMatchStatRequest
    {
        // The ID of the PlayerMatchStat
        public int PlayerMatchStatId { get; set; }
        // The ID of the Player
        public int PlayerId { get; set; }
        // The ID of the Match
        public int MatchId { get; set; }
        // The number of the team that the Player was on
        public int TeamNumber { get; set; }
        // The number of Kills the Player got in this Match
        public int Kills { get; set; }
        // The number of Deaths the Player had in this Match
        public int Deaths { get; set; }
        // The number of Assists the Player had in this Match
        public int Assists { get; set; }
    }
}