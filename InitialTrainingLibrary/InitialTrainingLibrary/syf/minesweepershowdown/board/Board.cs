using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.minesweepershowdown.interfaces;

namespace InitialTrainingLibrary.syf.minesweepershowdown.board
{
    public abstract class Board : IBoard
    {
        protected IBoardField[,] fields;

        public virtual IBoardField[,] GetFields()
        {
           // IBoardField fields = new IBoardField();
            return fields;
        }
    }
}
