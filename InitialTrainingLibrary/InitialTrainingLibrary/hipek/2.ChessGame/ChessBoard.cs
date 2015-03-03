using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public class ChessBoard :IBoard
    {
        protected IBoardField[,] Fields;

        public ChessBoard()
        {
            this.Fields = new ChessBoardField[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j==0 || j ==1 || j == 6 || j == 7)
                    {
                        this.Fields[i, j] = new ChessBoardField(i, j, true);
                    }
                    else
                    {
                        this.Fields[i, j] = new ChessBoardField(i, j, false);
                    }
                    
                }
            }

            
        }

        public IBoardField[,] GetFields()
        {
            return this.Fields;
        }

        public string GetName()
        {
            return "Hipek";
        }
    } 
}
