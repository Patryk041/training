using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyBishop : CoouseyFigure
    {
        public CoouseyBishop(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoordinates)
        {
            return                        
                Math.Abs(newCoordinates.GetX() - Coordinates.GetX()) ==     
                Math.Abs(newCoordinates.GetY() - Coordinates.GetY());    
        }

        public override bool WayIsEmpty(ICoordinates newCoo)
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
