using Microsoft.AspNetCore.Mvc;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController(IPlayerService service) : ControllerBase
    {
        // Reference: Updated Controller after Dtos - https://youtu.be/RwQVRXEs370?si=edblfYxP61HN3ZPn&t=3617

        // Get all Players
        [HttpGet]
        public async Task<ActionResult<List<PlayerResponse>>> GetPlayers()
            => Ok(await service.GetAllPlayersAsync());

        // Get Player by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerResponse>> GetPlayerById(int id)
        {
            var player = await service.GetPlayerByIdAsync(id);
            return player is null ? NotFound("No Player found with this id. ") : Ok(player);
        }

        // Get Player by Name
        [HttpGet("{name}")]
        public async Task<ActionResult<PlayerResponse>> GetPlayerByName(string inGameName)
        {
            var player = await service.GetPlayerByInGameNameAsync(inGameName);
            return player is null ? NotFound("No player found with this name. ") : Ok(player);
        }

        // Add Player
        [HttpPost]
        public async Task<ActionResult<PlayerResponse>> AddPlayer(CreatePlayerRequest player)
        {
            var createdPlayer = await service.AddPlayerAsync(player);
            return CreatedAtAction(nameof(GetPlayerById), new { id = createdPlayer.Id }, createdPlayer);
        }

        // Update existing Player
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePlayer(int id, UpdatePlayerRequest player)
        {
            var updated = await service.UpdatePlayerAsync(id, player);
            return updated ? NoContent() : NotFound("Player with the given Id was not found. ");
        }

        // Delete existing Player
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePlayer(int id)
        {
            var deleted = await service.DeletePlayerAsync(id);
            return deleted ? NoContent() : NotFound("Player with the given Id was not found.");
        }
    }
}