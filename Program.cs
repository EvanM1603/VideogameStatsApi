using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Data;
using VideogameStatsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddSwaggerGen();

// Reference: Added DbContext to the Program.cs - https://youtu.be/RwQVRXEs370?si=GIacU5Rxmkbqyynq&t=2796
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Reference: Added Services and Service Interfaces - https://youtu.be/RwQVRXEs370?si=RoMOvWGPi6bd2YNl&t=1466
builder.Services.AddScoped<IGameService, GameService>();
//builder.Services.AddScoped<IMatchService, MatchService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
//builder.Services.AddScoped<IPlayerMatchStatService, PlayerMatchStatService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();