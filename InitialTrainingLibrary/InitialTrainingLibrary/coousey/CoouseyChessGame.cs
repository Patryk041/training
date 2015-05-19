using InitialTrainingLibrary.Interfaces.chess;


namespace InitialTrainingLibrary.coousey
{
    public class CoouseyChessGame : IGame
    {
        private readonly IBoard _board;

        public CoouseyChessGame()
        {
            _board = new CoouseyBoard(8,8);
        }

        public IBoard GetBoard()
        {
            return _board;
        }
    }
}
