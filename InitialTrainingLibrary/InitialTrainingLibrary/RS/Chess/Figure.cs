using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.RS.Chess
{
    public class Figure : IFigure
    {
        private readonly FigureColorEnum _figureColor;
        private ICoordinates _coordinates;
        private readonly FigureKind _figureKind;

        public Figure(FigureColorEnum figureColor, ICoordinates coordinates, FigureKind figureKind)
        {
            _figureColor = figureColor;
            _coordinates = coordinates;
            _figureKind = figureKind;
        }

        public bool IsFigureWhite()
        {
            return _figureColor == FigureColorEnum.White;
        }

        public ICoordinates GetCoordinates()
        {
            return _coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return _figureKind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            _coordinates = newCoordinates;
            return true;
        }
    }
}
