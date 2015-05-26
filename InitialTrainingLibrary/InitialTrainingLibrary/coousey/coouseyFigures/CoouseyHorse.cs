using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyHorse : CoouseyFigure
    {
        public CoouseyHorse(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoo)
        {
            return
                (Coordinates.GetX() - 1 == newCoo.GetX() && Coordinates.GetY() - 2 == newCoo.GetY()) ||
                (Coordinates.GetX() - 1 == newCoo.GetX() && Coordinates.GetY() + 2 == newCoo.GetY()) ||
                (Coordinates.GetX() - 2 == newCoo.GetX() && Coordinates.GetY() - 1 == newCoo.GetY()) ||
                (Coordinates.GetX() - 2 == newCoo.GetX() && Coordinates.GetY() + 1 == newCoo.GetY()) ||
                (Coordinates.GetX() + 1 == newCoo.GetX() && Coordinates.GetY() - 2 == newCoo.GetY()) ||
                (Coordinates.GetX() + 1 == newCoo.GetX() && Coordinates.GetY() + 2 == newCoo.GetY()) ||
                (Coordinates.GetX() + 2 == newCoo.GetX() && Coordinates.GetY() - 1 == newCoo.GetY()) ||
                (Coordinates.GetX() + 2 == newCoo.GetX() && Coordinates.GetY() + 1 == newCoo.GetY());
        }

        public override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            return true;
        }
    }
}
