using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.warrior.chess.figures
{
    public abstract class Figure : IFigure
    {
        public bool IsFigureWhite()
        {
            throw new NotImplementedException();
        }

        public abstract ICoordinates GetCoordinates();

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
