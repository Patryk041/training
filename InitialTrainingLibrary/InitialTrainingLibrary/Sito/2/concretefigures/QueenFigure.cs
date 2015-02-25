using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Sito._2.figuressets;

namespace InitialTrainingLibrary.Sito._2.concretefigures
{
    class QueenFigure:SingleFigureSet
    {
        public QueenFigure(bool isWhite)
        {
            figure = new Figure(isWhite,FigureKind.King);
        }
    }
}
