using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyRook : CoouseyFigure
    {
        public CoouseyRook(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidDestination(ICoordinates newCoo)
        {
            return
                Coordinates.GetX() != newCoo.GetX() ^      
                Coordinates.GetY() != newCoo.GetY();
        }

        protected override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            bool horizontal = Coordinates.GetX() != newCoordinates.GetX();

            int dir;
            int d;

            if (horizontal)
            {
                dir = newCoordinates.GetX() > Coordinates.GetX() ? 1 : -1;
                d = Math.Abs(newCoordinates.GetX() - Coordinates.GetX());

                for (int i = 1; i < d; i++)
                {
                    if (BoardFields[Coordinates.GetX() + i*dir, Coordinates.GetY()].HasFigure())
                    {
                        return false;
                    }
                }
                return true; 
            }

            dir = newCoordinates.GetY() > Coordinates.GetY() ? 1 : -1;
            d = Math.Abs(newCoordinates.GetY() - Coordinates.GetY());

            for (int i = 1; i < d; i++)
            {
                if (BoardFields[Coordinates.GetX(), Coordinates.GetY() + i*dir].HasFigure())
                {
                    return false;
                }
            }
            return true; 
        }
    }
}
