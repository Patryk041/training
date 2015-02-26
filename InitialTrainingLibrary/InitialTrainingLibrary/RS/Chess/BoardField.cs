using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.RS.Chess
{
    public class BoardField : IBoardField
    {
        private readonly FieldColorEnum _fieldColor;
        private readonly ICoordinates _coordinates;
        private IFigure _figure;

        public BoardField(FieldColorEnum fieldColor, ICoordinates coordinates)
        {
            _fieldColor = fieldColor;
            _coordinates = coordinates;
        }

        public BoardField(FieldColorEnum fieldColor, ICoordinates coordinates, IFigure figure)
        {
            _fieldColor = fieldColor;
            _coordinates = coordinates;
            _figure = figure;
        }

        public bool IsFieldWhite()
        {
            return _fieldColor == FieldColorEnum.White;
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
