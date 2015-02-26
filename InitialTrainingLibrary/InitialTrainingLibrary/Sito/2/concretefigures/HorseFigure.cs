using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Sito._2.figuressets;

namespace InitialTrainingLibrary.Sito._2.concretefigures
{
    class HorseFigure:MultipleFigureSet
    {
        public HorseFigure(bool isWhite)
        {
            figures = new List<Figure>();

            for (int i = 0; i < 2; i++)
            {
                figures.Add(new Figure(isWhite,FigureKind.Horse,i));
            }
        }
    }
}
