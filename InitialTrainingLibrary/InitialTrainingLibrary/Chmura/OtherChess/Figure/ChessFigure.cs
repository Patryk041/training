using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess.Figure
{
    public abstract class ChessFigure : IFigure
    {
        public abstract bool IsFigureWhite();
        public abstract ICoordinates GetCoordinates();
        public abstract FigureKind GetFigureKind();
        public abstract bool Move(ICoordinates newCoordinates);


    }
}
