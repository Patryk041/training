using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyBishop : CoouseyFigure
    {
        public CoouseyBishop(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidateMove(ICoordinates newCoordinates)
        {
            return
                base.ValidateMove(newCoordinates) &&                        // not the same position or out of bound
                Math.Abs(newCoordinates.GetX() - Coordinates.GetX()) ==     // the same distance in both directions
                Math.Abs(newCoordinates.GetY() - Coordinates.GetY());    

        }
    }
}
