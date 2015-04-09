using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.R4D3K.Chess.Figures
{
    class Horse : ChessFigure
    {
        public Horse(int x, int y, bool isWhite) : base(x, y, isWhite)
        {
            this.kind = FigureKind.Horse;
            this.isWhite = isWhite;
            this.coor = new Coordinates(x, y);
        }
    }
}
