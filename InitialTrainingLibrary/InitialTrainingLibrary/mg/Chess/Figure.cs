using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess
{
    abstract class Figure :IFigure
    {
        protected FigureKind figureKind;
        protected Coordinates coordinates;
        protected bool isWhite;

        public bool IsFigureWhite()
        {
            return isWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return figureKind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
