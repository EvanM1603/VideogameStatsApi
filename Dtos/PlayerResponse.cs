namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // The DTO returned when reading Player Data
    public class PlayerResponse
    {
        // The ID of the Player
        public int Id { get; set; }
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
    }
}