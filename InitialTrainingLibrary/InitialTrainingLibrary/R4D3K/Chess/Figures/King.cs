using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.R4D3K.Chess.Figures
{
    class King : ChessFigure
    {
        public King(int x, int y,bool isWhite) : base(x, y, isWhite)
        {
            this.kind = FigureKind.King;
            this.isWhite = isWhite;
            this.coor = new Coordinates(x, y);
        }
    }
}
