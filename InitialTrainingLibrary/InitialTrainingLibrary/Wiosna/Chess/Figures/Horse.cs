using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Wiosna.Chess.Figures
{
    class Horse : Figure
    {
        public Horse(int x, int y, bool isWhite) : base(x,y,isWhite)
        {
            coordinates =  new Coordinates(x,y);
            this.kind = FigureKind.Horse;
        }
    }
}
