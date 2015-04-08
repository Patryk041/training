using InitialTrainingLibrary.Interfaces.chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.R4D3K.Chess
{
    public abstract class Figure : IFigure
    {
        public abstract ICoordinates GetCoordinates();

        public abstract FigureKind GetFigureKind();

        public abstract bool IsFigureWhite();

        public abstract bool Move(ICoordinates newCoordinates);
    }
}
