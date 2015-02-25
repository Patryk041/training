using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2.figuressets
{
    class KingFigure:SingleFigureSet
    {
        public KingFigure(bool isWhite)
        {
            figure = new Figure(isWhite,FigureKind.King);
        }
    }
}
