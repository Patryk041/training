using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.minesweepershowdown.board
{
    public class ChessBoard : Board
    {
        public ChessBoard()
        {
            this.fields = new ChessBoardField[8,8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.fields[i,j] = new ChessBoardField(i, j);
                }
            }
        }
    }
}
