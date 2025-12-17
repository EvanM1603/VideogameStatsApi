namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // The DTO returned when reading Game Data
    public class GameResponse
    {
        // The ID of the Game
        public int Id { get; set; }
        // The Name of the Game
        public string Name { get; set; } = string.Empty;
    }
}