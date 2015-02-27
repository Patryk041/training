using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess.Board
{
    public class ChessBoardField : BoardField, IBoardField
    {
        public ChessBoardField(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
    }
}
