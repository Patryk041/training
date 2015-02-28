using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.Chess;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.dysq
{
   public class ChessBoard : IBoard
   {
       private IBoardField[,] BoardFields = new IBoardField[8,8];

       public ChessBoard()
       {
           for (int i=0; i < 8; i++)
           {

               for (int j = 0; j < 8; j++)
               {
                   BoardFields[i,j] = new ChessBoardField(i,j);
               }
           }
       }

       public IBoardField[,] GetFields()
       {
           return BoardFields;
       }

       public string GetName()
       {
           throw new NotImplementedException();
       }
   }
}
