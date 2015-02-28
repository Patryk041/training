using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.RS.Chess
{
    public class Board : IBoard
    {
        private readonly IBoardField[,] _boardFields;

        public Board(IBoardField[,] boardFields)
        {
            _boardFields = boardFields;
        }

        public IBoardField[,] GetFields()
        {
            return _boardFields;
        }

        public string GetName()
        {
            return "Rs";
        }
    }
}
