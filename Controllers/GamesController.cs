using Microsoft.AspNetCore.Mvc;
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

    public async Task<ActionResult<List<GameDto>>> GetGames()
        => Ok(await service.GetAllGamesAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGame(int id)
    {
        var game = await service.GetGameByIdAsync(id);
        return game is null ? NotFound("No game found with this id. ") : Ok(game);
    }

    }