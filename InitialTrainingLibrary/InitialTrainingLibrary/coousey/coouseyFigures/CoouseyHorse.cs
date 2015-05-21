using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyHorse : CoouseyFigure
    {
        public CoouseyHorse(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidateMove(ICoordinates newCoordinates)
        {
            return
                base.ValidateMove(newCoordinates) &&    // not the same position or out of bound
                ((Coordinates.GetX() - 1 == newCoordinates.GetX() && Coordinates.GetY() - 2 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() - 1 == newCoordinates.GetX() && Coordinates.GetY() + 2 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() - 2 == newCoordinates.GetX() && Coordinates.GetY() - 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() - 2 == newCoordinates.GetX() && Coordinates.GetY() + 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 1 == newCoordinates.GetX() && Coordinates.GetY() - 2 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 1 == newCoordinates.GetX() && Coordinates.GetY() + 2 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 2 == newCoordinates.GetX() && Coordinates.GetY() - 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 2 == newCoordinates.GetX() && Coordinates.GetY() + 1 == newCoordinates.GetY()));
        }
    }
}
