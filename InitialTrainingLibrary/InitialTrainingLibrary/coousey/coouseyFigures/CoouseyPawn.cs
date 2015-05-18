using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyPawn : CoouseyFigure
    {
        public CoouseyPawn(bool isWhite, CoouseyCoordinates coordinates, FigureKind figureKind) : base(isWhite, coordinates, figureKind)
        {
        }

        public new bool Move(ICoordinates newCoordinates)
        {
            return true;
        }
    }
}
