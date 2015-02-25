using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.dysq.Chess.Figures
{
    public class King : Figure
    {
        public King(int x, int y, bool colour) : base(x, y, colour)
        {
            kindOfFigure = FigureKind.King;
        }

    }
}
