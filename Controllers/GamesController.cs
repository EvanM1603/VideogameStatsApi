using Microsoft.AspNetCore.Mvc;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController(IGameService service) : ControllerBase
    {
        // Reference: Updated Controller after Dtos - https://youtu.be/RwQVRXEs370?si=edblfYxP61HN3ZPn&t=3617

        // Get all Games
        [HttpGet]
        public async Task<ActionResult<List<GameResponse>>> GetGames()
            => Ok(await service.GetAllGamesAsync());

        // Get Game by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<GameResponse>> GetGameById(int id)
        {
            var game = await service.GetGameByIdAsync(id);
            return game is null ? NotFound("No game found with this id. ") : Ok(game);
        }

        // Get Game by Name
        [HttpGet("{name}")]
        public async Task<ActionResult<GameResponse>> GetGameByName(string name)
        {
            var game = await service.GetGameByNameAsync(name);
            return game is null ? NotFound("No game found with this name. ") : Ok(game);
        }

        // Add Game
        [HttpPost]
        public async Task<ActionResult<GameResponse>> AddGame(CreateGameRequest game)
        {
            var createdGame = await service.AddGameAsync(game);
            return CreatedAtAction(nameof(GetGameById), new { id = createdGame.Id }, createdGame);
        }

        // Update existing Game
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateGame(int id, UpdateGameRequest game)
        {
            var updated = await service.UpdateGameAsync(id, game);
            return updated ? NoContent() : NotFound("Game with the given Id was not found. ");
        }

        // Delete existing Game
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteGame(int id)
        {
            var deleted = await service.DeleteGameAsync(id);
            return deleted ? NoContent() : NotFound("Game with the given Id was not found.");
        }

    }
}