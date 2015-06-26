using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyQueen : CoouseyFigure
    {
        public CoouseyQueen(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoo)
        {
            return
                Math.Abs(newCoo.GetX() - Coordinates.GetX()) ==      // the same distance in both directions
                Math.Abs(newCoo.GetY() - Coordinates.GetY()) || 
               (Coordinates.GetX() != newCoo.GetX() ^             // change in exactly one direction
                Coordinates.GetY() != newCoo.GetY());
        }

        public override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            int xDir;
            int yDir;
            int d;

            if (Coordinates.GetX() != newCoordinates.GetX() && Coordinates.GetY() == newCoordinates.GetY())
            {
                xDir = newCoordinates.GetX() > Coordinates.GetX() ? 1 : -1;
                d = Math.Abs(newCoordinates.GetX() - Coordinates.GetX());

                for (int i = 1; i < d; i++)
                {
                    if (BoardFields[Coordinates.GetX() + i * xDir, Coordinates.GetY()].HasFigure())
                    {
                        return false;
                    }
                }
                return true;
            }
            if (Coordinates.GetX() == newCoordinates.GetX() && Coordinates.GetY() != newCoordinates.GetY())
            {

                yDir = newCoordinates.GetY() > Coordinates.GetY() ? 1 : -1;
                d = Math.Abs(newCoordinates.GetY() - Coordinates.GetY());

                for (int i = 1; i < d; i++)
                {
                    if (BoardFields[Coordinates.GetX(), Coordinates.GetY() + i*yDir].HasFigure())
                    {
                        return false;
                    }
                }
                return true;
            }

            xDir = newCoordinates.GetX() > Coordinates.GetX() ? 1 : -1;
            yDir = newCoordinates.GetY() > Coordinates.GetY() ? 1 : -1;
            d = Math.Abs(newCoordinates.GetX() - Coordinates.GetX());

            for (int i = 1; i < d; i++)
            {
                if (BoardFields[Coordinates.GetX() + i * xDir, Coordinates.GetY() + i * yDir].HasFigure())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
