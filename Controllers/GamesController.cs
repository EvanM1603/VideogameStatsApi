using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Models;
using VideogameStatsApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController(IGameService service) : ControllerBase
{
    // Reference: Updated Controller - https://youtu.be/RwQVRXEs370?si=XSSpE8rut7tKsh1i&t=1245 

    [HttpGet]
    public async Task<ActionResult<List<GameResponse>>> GetGames()
        => Ok(await service.GetAllGamesAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGame(int id)
    {
        var game = await service.GetGameByIdAsync(id);
        return game is null ? NotFound("No game found with this id. ") : Ok(game);
    }

    [HttpPost]
    public async Task<ActionResult<GameResponse>> AddGame(CreateGameRequest game)
    {
        var createdGame = await service.AddGameAsync(game);
        return CreatedAtAction(nameof(GetGame), new { id = createdGame.Id }, createdGame);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateGame(int id, UpdateGameRequest game)
    {
        var updated = await service.UpdateGameAsync(id, game);
        return updated ? NoContent() : NotFound("Game with the given Id was not found. ");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteGame(int id)
    {
        var deleted = await service.DeleteGameAsync(id);
        return deleted ? NoContent() : NotFound("Game with the given Id was not found.");
    }

}