using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyKing : CoouseyFigure
    {
        public CoouseyKing(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidateMove(ICoordinates newCoordinates)
        {
            return 
                base.ValidateMove(newCoordinates) &&
                ((Coordinates.GetX() - 1 == newCoordinates.GetX() && Coordinates.GetY() - 1 == newCoordinates.GetY()) ||    // diagonal
                 (Coordinates.GetX() - 1 == newCoordinates.GetX() && Coordinates.GetY() + 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 1 == newCoordinates.GetX() && Coordinates.GetY() - 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 1 == newCoordinates.GetX() && Coordinates.GetY() + 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() + 1 == newCoordinates.GetX() && Coordinates.GetY() == newCoordinates.GetY()) ||        // horizontal and vertical
                 (Coordinates.GetX() - 1 == newCoordinates.GetX() && Coordinates.GetY() == newCoordinates.GetY()) ||
                 (Coordinates.GetX() == newCoordinates.GetX() && Coordinates.GetY() + 1 == newCoordinates.GetY()) ||
                 (Coordinates.GetX() == newCoordinates.GetX() && Coordinates.GetY() - 1 == newCoordinates.GetY())); 
        }
    }
}
