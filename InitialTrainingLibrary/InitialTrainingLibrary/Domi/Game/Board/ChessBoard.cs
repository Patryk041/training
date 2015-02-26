using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessBoard : IBoard     // plansza szachów
    {
       // 1.muszę namalować plansze 8,8 szachów 
       // 2. potrzebuje pola do uzupełninia planszy
      //  3.pola na planszy muszą mieć kolor

 

       public IBoardField[,] GetFields()
       {
           throw new NotImplementedException();
       }
    }
}
