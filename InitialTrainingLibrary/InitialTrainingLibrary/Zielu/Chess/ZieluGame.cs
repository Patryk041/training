using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Zielu.Chess
{
    public class ZieluGame : IGame
    {
        public IBoard GetBoard()
        {
            return new ZieluBoard();
        }
    }
}
