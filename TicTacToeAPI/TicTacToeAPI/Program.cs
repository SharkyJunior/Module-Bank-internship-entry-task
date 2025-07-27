using Microsoft.EntityFrameworkCore;
using TicTacToeAPI.Models;
using TicTacToeAPI.Database;

var builder = WebApplication.CreateBuilder(args);

// adding local PostgreSQL connection information
builder.Configuration.AddUserSecrets<Program>();

var connectionString = builder.Configuration["ConnectionStrings:DatabaseConnection"];

// Add services to the container.

builder.Services.AddDbContext<TicTacToeDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Configuration.AddEnvironmentVariables();

builder.Services.Configure<GameSettings>(
    builder.Configuration.GetSection("GameSettings")
);

var app = builder.Build();

app.MapGet("/health", () => Results.Ok("Healthy"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
