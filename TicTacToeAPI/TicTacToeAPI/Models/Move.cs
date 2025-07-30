namespace TicTacToeAPI.Models
{
    public class Move
    {
        public int Id { get; set; }
        public int NextMoveId { get; set; }
        public int GameId { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
