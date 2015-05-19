using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    abstract class CoouseyFigure : IFigure
    {
        protected readonly CoouseyCoordinates Coordinates;
        protected readonly FigureKind FigureKind;

        private const int UpperBlackRow = 4;

        protected CoouseyFigure(CoouseyCoordinates coordinates, FigureKind figureKind)
        {
            Coordinates = coordinates;
            FigureKind = figureKind;
        }

        public bool IsFigureWhite()
        {
            return Coordinates.GetY() < UpperBlackRow;
        }

        public ICoordinates GetCoordinates()
        {
            return Coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return FigureKind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
