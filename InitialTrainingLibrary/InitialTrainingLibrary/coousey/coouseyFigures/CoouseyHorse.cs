using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyHorse : CoouseyFigure
    {
        public CoouseyHorse(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidDestination(ICoordinates newCoo)
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

        protected override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            return true;
        }
    }
}
