using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.minesweepershowdown.board
{
    public class ChessBoardField : BoardField
    {
        public ChessBoardField(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool IsFieldWhite()
        {
            return (this.GetX() + this.GetY()) % 2 == 0;
        }
    }
}
