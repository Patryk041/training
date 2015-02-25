using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2.figuressets
{
    class PawnFigure:MultipleFigureSet
    {
        public PawnFigure(bool isWhite)
        {
            figures = new List<Figure>();

            for (int i = 0; i < 8; i++)
            {
                figures.Add(new Figure(isWhite,FigureKind.Pawn,i));
            }
        }
    }
}
