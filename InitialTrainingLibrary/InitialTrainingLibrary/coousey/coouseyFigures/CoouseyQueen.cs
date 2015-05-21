using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyQueen : CoouseyFigure
    {
        public CoouseyQueen(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidateMove(ICoordinates newCoordinates)
        {
            return
                base.ValidateMove(newCoordinates) &&                        // not the same position or out of bound
                (Math.Abs(newCoordinates.GetX() - Coordinates.GetX()) ==    // the same distance in both directions
                 Math.Abs(newCoordinates.GetY() - Coordinates.GetY()) || 
                ((Coordinates.GetX() != newCoordinates.GetX() ^             // change in exactly one direction
                 Coordinates.GetY() != newCoordinates.GetY())));
        }
    }
}
