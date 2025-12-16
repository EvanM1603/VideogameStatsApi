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
        // Reference: Updated Controller - https://youtu.be/RwQVRXEs370?si=XSSpE8rut7tKsh1i&t=1245 

        [HttpGet]
        public async Task<ActionResult<List<PlayerResponse>>> GetPlayers()
            => Ok(await service.GetAllPlayersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerResponse>> GetPlayer(int id)
        {
            var player = await service.GetPlayerByIdAsync(id);
            return player is null ? NotFound("No Player found with this id. ") : Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<PlayerResponse>> AddPlayer(CreatePlayerRequest player)
        {
            var createdPlayer = await service.AddPlayerAsync(player);
            return CreatedAtAction(nameof(GetPlayer), new { id = createdPlayer.Id }, createdPlayer);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePlayer(int id, UpdatePlayerRequest player)
        {
            var updated = await service.UpdatePlayerAsync(id, player);
            return updated ? NoContent() : NotFound("Player with the given Id was not found. ");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePlayer(int id)
        {
            var deleted = await service.DeletePlayerAsync(id);
            return deleted ? NoContent() : NotFound("Player with the given Id was not found.");
        }
    }
}