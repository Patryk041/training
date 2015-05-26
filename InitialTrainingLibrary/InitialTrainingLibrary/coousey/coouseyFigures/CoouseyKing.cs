using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyKing : CoouseyFigure
    {
        public CoouseyKing(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoo)
        {
            return
                (Coordinates.GetX() - 1 == newCoo.GetX() && Coordinates.GetY() - 1 == newCoo.GetY()) ||    // diagonal
                (Coordinates.GetX() - 1 == newCoo.GetX() && Coordinates.GetY() + 1 == newCoo.GetY()) ||
                (Coordinates.GetX() + 1 == newCoo.GetX() && Coordinates.GetY() - 1 == newCoo.GetY()) ||
                (Coordinates.GetX() + 1 == newCoo.GetX() && Coordinates.GetY() + 1 == newCoo.GetY()) ||
                (Coordinates.GetX() + 1 == newCoo.GetX() && Coordinates.GetY() == newCoo.GetY()) ||        // horizontal and vertical
                (Coordinates.GetX() - 1 == newCoo.GetX() && Coordinates.GetY() == newCoo.GetY()) ||
                (Coordinates.GetX() == newCoo.GetX() && Coordinates.GetY() + 1 == newCoo.GetY()) ||
                (Coordinates.GetX() == newCoo.GetX() && Coordinates.GetY() - 1 == newCoo.GetY()); 
        }

        public override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            return true;
        }
    }
}
