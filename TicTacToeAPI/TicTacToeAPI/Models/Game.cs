using System.Numerics;
using TicTacToeAPI.Models.Enums;

namespace TicTacToeAPI.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public uint BoardSize { get; set; }

        public char[][] Board { get; set; }

        GameState State { get; } = GameState.InProgress;

        public Game(uint boardSize)
        {
            BoardSize = boardSize;
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            Board = new char[BoardSize][];
            for (int i = 0; i < BoardSize; i++)
            {
                Board[i] = new char[BoardSize];
                for (int j = 0; j < BoardSize; j++)
                    Board[i][j] = ' ';
            }
                
        }   
    }
}
