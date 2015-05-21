using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyRook : CoouseyFigure
    {
        public CoouseyRook(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidateMove(ICoordinates newCoordinates)
        {
            return
                base.ValidateMove(newCoordinates) &&                // not the same position or out of bound
                (Coordinates.GetX() != newCoordinates.GetX() ^      // change in exactly one direction
                 Coordinates.GetY() != newCoordinates.GetY());
        }
    }
}
