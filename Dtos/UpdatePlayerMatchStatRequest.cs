namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // DTO used to update an existing Game
    public class UpdatePlayerMatchStatRequest
    {
        // The TeamNumber of the Player in this Match
        public int TeamNumber { get; set; }
        // The number of Kills the Player got in this Match
        public int Kills { get; set; }
        // The number of Deaths the Player had in this Match
        public int Deaths { get; set; }
        // The number of Assists the Player had in this Match
        public int Assists { get; set; }
    }
}