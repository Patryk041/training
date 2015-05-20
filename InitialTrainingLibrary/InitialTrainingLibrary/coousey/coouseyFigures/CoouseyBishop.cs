using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyBishop : CoouseyFigure
    {
        public CoouseyBishop(ICoordinates coordinates, FigureKind figureKind) : base(coordinates, figureKind)
        {
        }

        public new bool Move(ICoordinates newCoordinates)
        {
            return true;
        }
    }
}
