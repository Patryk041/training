using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.robson.ChessGame
{
    class ChessBoardFieldCoordinates : ICoordinates
    {
        private int X{get; set;}
        private int Y{get; set;}
        public ChessBoardFieldCoordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
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
