using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess.Board
{
    public abstract class Board : IBoard
    {
        public ChessBoardField[,] fields;

        public virtual IBoardField[,] GetFields()
        {
            // IBoardField fields = new IBoardField();
            return (IBoardField[,]) fields;
        }

        public string GetName()
        {
            return "Chmura";
        }
    }
}
