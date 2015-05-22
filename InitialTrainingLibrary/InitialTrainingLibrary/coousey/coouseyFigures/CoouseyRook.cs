using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyRook : CoouseyFigure
    {
        public CoouseyRook(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoo)
        {
            return
                Coordinates.GetX() != newCoo.GetX() ^      
                Coordinates.GetY() != newCoo.GetY();
        }

        public override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            int dir;
            int d;

            if (Coordinates.GetX() != newCoordinates.GetX())
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
