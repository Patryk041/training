using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    class Figure:IFigure
    {
        public bool IsFigureWhite()
        {
            throw new NotImplementedException();
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
