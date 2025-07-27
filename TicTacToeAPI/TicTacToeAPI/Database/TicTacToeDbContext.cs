using Microsoft.EntityFrameworkCore;

namespace TicTacToeAPI.Database
{
    public class TicTacToeDbContext : DbContext
    {
        public TicTacToeDbContext(DbContextOptions<TicTacToeDbContext> options)
        : base(options)
        {
        }
    }
}
