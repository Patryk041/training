using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyBishop : CoouseyFigure
    {
        public CoouseyBishop(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidDestination(ICoordinates newCoo)
        {
            return                        
                Math.Abs(newCoo.GetX() - Coordinates.GetX()) ==     
                Math.Abs(newCoo.GetY() - Coordinates.GetY());    
        }

        protected override bool WayIsEmpty(ICoordinates newCoo)
        {
            int xDir = newCoo.GetX() > Coordinates.GetX() ? 1 : -1;
            int yDir = newCoo.GetY() > Coordinates.GetY() ? 1 : -1;
            int d = Math.Abs(newCoo.GetX() - Coordinates.GetX());

            for (int i = 1; i < d; i++) 
            {
                if (BoardFields[Coordinates.GetX() + i*xDir, Coordinates.GetY() + i*yDir].HasFigure())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
