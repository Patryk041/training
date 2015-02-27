using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public class ChessCoordinates : ICoordinates
    {
        protected int X;
        protected int Y;

        public ChessCoordinates()
        {

        }

        public ChessCoordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int GetX()
        {
            return X;
        }

        public void SetX(int value)
        {
            X = value;
        }


        public int GetY()
        {
            return Y;
        }

        public void SetY(int value)
        {
            X = value;
        }
    }
}
