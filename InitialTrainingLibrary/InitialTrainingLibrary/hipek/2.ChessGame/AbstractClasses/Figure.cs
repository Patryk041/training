using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame.AbstractClasses
{
    public abstract class Figure : IFigure
    {
        public bool IsFigureWhite()
        {
            throw new NotImplementedException();
            //sdasda
        }

        public ICoordinates GetCoordinates()
        {
            throw new NotImplementedException();
        }

        public FigureKind GetFigureKind()
        {
            throw new NotImplementedException();
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
