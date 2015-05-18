using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    abstract class CoouseyFigure : IFigure
    {
        protected readonly bool IsWhite;
        protected readonly CoouseyCoordinates Coordinates;
        protected readonly FigureKind FigureKind;

        protected CoouseyFigure(bool isWhite, CoouseyCoordinates coordinates, FigureKind figureKind)
        {
            IsWhite = isWhite;
            Coordinates = coordinates;
            FigureKind = figureKind;
        }

        public bool IsFigureWhite()
        {
            return IsWhite ;
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
