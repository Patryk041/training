using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.robson.ChessGame
{
    class ChessBoard : IBoard
    {
        ChessBoardField[,] chessBoardFields = new ChessBoardField[8, 8];

        public ChessBoard()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    chessBoardFields[i, j] = new ChessBoardField(i, j);
                }
            }
        }
        public IBoardField[,] GetFields()
        {
            return chessBoardFields;
        }

        public string GetName()
        {
            return "Robson :-)";
        }
    }
}
