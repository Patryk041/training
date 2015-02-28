using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess
{
    public class ChessBoard : IBoard
    {
       
        IBoardField[,] chessFields = new IBoardField[8,8];

        public ChessBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessFields[i,j] = new ChessBoardField(i,j);
                }
            }
            
        }
        public IBoardField[,] GetFields()
        {
            return chessFields;
        }

        public string GetName()
        {
            return "mg";
        }
    }
}
