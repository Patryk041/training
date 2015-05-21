using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyQueen : CoouseyFigure
    {
        public CoouseyQueen(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidDestination(ICoordinates newCoo)
        {
            return
                Math.Abs(newCoo.GetX() - Coordinates.GetX()) ==      // the same distance in both directions
                Math.Abs(newCoo.GetY() - Coordinates.GetY()) || 
              (Coordinates.GetX() != newCoo.GetX() ^             // change in exactly one direction
                Coordinates.GetY() != newCoo.GetY());
        }

        protected override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
