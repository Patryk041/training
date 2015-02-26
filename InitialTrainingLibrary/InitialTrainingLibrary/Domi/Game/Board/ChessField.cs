using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessField: Field   //pola gry szachy 
    {
       public ChessField(int x, int y) : base(x,y) //czemu potrzebuję tego base?? Resharper mi kazał zrobić.. 
       {
           this.x = x;
           this.y = y; 
       }

       public bool IsWhtieField()   //wiemy ze szachy maja dwa kolory pól 
       {
           return (this.GetX() + this.GetY()) % 2 == 0; //pola białe
       }

       public bool IsBlackField()
       {
           return (this.GetX() + this.GetY()) % 2 == 1; // pola czarne 
       }
    }
}
