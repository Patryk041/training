using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey
{
    class CoouseyBoardField : IBoardField
    {
        private readonly ICoordinates _coordinates;
        private IFigure _figure;

        public CoouseyBoardField(ICoordinates coordinates, IFigure figure)
        {
            _coordinates = coordinates;
            _figure = figure;
        }

        public bool IsFieldWhite()
        {
            return (_coordinates.GetX() + _coordinates.GetY()) % 2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return _coordinates;
        }

        public bool HasFigure()
        {
            return _figure != null;
        }

        public void SetFigure(IFigure figure)
        {
            _figure = figure;
        }

        public IFigure GetFigure()
        {
            return _figure;
        }
    }
}
