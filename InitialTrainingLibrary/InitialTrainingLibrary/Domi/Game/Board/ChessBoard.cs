using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessBoard : Board     // plansza szachów
    {
       // 1.muszę namalować plansze 8,8 szachów 
       // 2. potrzebuje pola do uzupełninia planszy
      //  3.pola na planszy muszą mieć kolor

       public ChessBoard()
       {
           this.Fields = new ChessField[8,8];   //do tablicy pól planszy przypisałam sobie tablice pól szachów 

           for (int i = 0; i < 8; i++)
           {
               for (int j = 0; j < 8; j++)
               {
                Fields[i,j]=  new ChessField(i,j); 
               }  
           }
       }

     
    }
}
