using Microsoft.EntityFrameworkCore;
using TicTacToeAPI.Models;

namespace TicTacToeAPI.Database
{
    public class TicTacToeDbContext : DbContext
    {
        public TicTacToeDbContext(DbContextOptions<TicTacToeDbContext> options)
        : base(options)
        {
        }

        DbSet<Game> games { get; set; }
        DbSet<Move> moves { get; set; }
    }
}
