using InitialTrainingLibrary.coousey.coouseyFigures;
using InitialTrainingLibrary.Interfaces.chess;


namespace InitialTrainingLibrary.coousey
{
    class CoouseyBoard : IBoard
    {
        private readonly IBoardField[,] _boardFields;

        public CoouseyBoard(int x, int y)
        {
            _boardFields = new IBoardField[x, y];

            for (int i = 0; i < _boardFields.GetLength(0); i++)
                for (int j = 0; j < _boardFields.GetLength(1); j++)
                {
                    CoouseyCoordinates coordinates = new CoouseyCoordinates(i, j);

                    _boardFields[i, j] = new CoouseyBoardField(coordinates);
                    _boardFields[i, j].SetFigure(CoouseyFigureFactory.GetNewFigure(coordinates));
                }
        }

        public IBoardField[,] GetFields()
        {
            return _boardFields;
        }

        public string GetName()
        {
            return "Coousey";
        }
    }
}
