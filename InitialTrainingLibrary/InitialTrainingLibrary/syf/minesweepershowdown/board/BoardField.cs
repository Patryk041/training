using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.minesweepershowdown.interfaces;

namespace InitialTrainingLibrary.syf.minesweepershowdown.board
{
    public abstract class BoardField : IBoardField
    {
        protected int X;
        protected int Y;

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
