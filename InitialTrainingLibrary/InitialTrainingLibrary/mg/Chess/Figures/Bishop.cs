using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess.Figures
{
    class Bishop : Figure
    {
        public Bishop(int x, int y,bool isWhite)
        {
        this.figureKind = FigureKind.Bishop;
        this.isWhite = isWhite;
        this.coordinates = new Coordinates(x,y);

        }
    }
}
