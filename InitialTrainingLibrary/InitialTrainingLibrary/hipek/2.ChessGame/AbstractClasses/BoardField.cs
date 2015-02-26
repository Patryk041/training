using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame.AbstractClasses
{
    public abstract class BoardField : IBoardField
    {
        public bool IsFieldWhite()
        {
            throw new NotImplementedException();
        }

        public ICoordinates GetCoordinates()
        {
            throw new NotImplementedException();
        }

        public bool HasFigure()
        {
            throw new NotImplementedException();
        }

        public void SetFigure(IFigure figure)
        {
            throw new NotImplementedException();
        }

        public IFigure GetFigure()
        {
            throw new NotImplementedException();
        }
    }
}
