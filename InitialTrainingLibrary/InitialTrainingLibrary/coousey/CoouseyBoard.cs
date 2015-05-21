using InitialTrainingLibrary.coousey.coouseyFigures;
using InitialTrainingLibrary.Interfaces.chess;


namespace InitialTrainingLibrary.coousey
{
    class CoouseyBoard : IBoard
    {
        private readonly IBoardField[,] _boardFields;

        public CoouseyBoard()
        {
            _boardFields = new IBoardField[8, 8];

            for (var i = 0; i < _boardFields.GetLength(0); i++)
            {
                for (var j = 0; j < _boardFields.GetLength(1); j++)
                {
                    var coordinates = new CoouseyCoordinates(j, i);
                    _boardFields[j, i] = new CoouseyBoardField(coordinates, CoouseyFigureFactory.GetNewFigureForCoordinate(coordinates));
                }
            }

            CoouseyFigure.SetBoardFields(_boardFields);
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
