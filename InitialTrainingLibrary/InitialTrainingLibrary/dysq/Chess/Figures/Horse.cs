using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.dysq.Chess.Figures
{
    public class Horse : Figure
    {
        public Horse(int x, int y, bool colour) : base(x,y,colour)
        {
            kindOfFigure = FigureKind.Horse;
            
        }


    }
}
