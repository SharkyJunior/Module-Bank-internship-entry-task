using Microsoft.AspNetCore.Mvc;
using TicTacToeAPI.Database;
using TicTacToeAPI.Services;

namespace TicTacToeAPI.Controllers
{
    public class GameController : Controller
    {
        private readonly TicTacToeDbContext _context;
        
        public GameController(TicTacToeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
