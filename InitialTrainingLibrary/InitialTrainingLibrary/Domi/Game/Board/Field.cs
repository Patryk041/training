using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using InitialTrainingLibrary.Domi.Game.Interface;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public abstract class Field : IField //jakieś pola gry 
   {
       protected int x;
       protected int y;

       public Field(int x, int y)
       {
           this.x = x;
           this.y = y; 
       }

       public int GetX()
       {
           return x; 
       }

       public int GetY()
       {
           return y;
       }
   }
}
