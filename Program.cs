using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Data;
using VideogameStatsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Reference: Created IGameService and GameService https://youtu.be/RwQVRXEs370?si=O2bIGmh8MfBt1CF_&t=1604 

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