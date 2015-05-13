using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Zielu.Chess
{
    class ZieluBoard : IBoard
    {
        private readonly IBoardField[,] _chessBoard;
        private const int Width = 8;
        private const int Height = 8;

        public ZieluBoard()
        {
            _chessBoard=new IBoardField[Width,Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    _chessBoard[i, j] = new ZieluBoardField(i, j);
                }
            }
        }
        public IBoardField[,] GetFields()
        {
            return _chessBoard;
        }

        public string GetName()
        {
            return "Zielu";
        }
    }
}
