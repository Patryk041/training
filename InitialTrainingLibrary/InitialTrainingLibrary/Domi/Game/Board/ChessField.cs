using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessField : IBoardField    //pola gry szachy 
    {  
       
       protected int x;
       protected int y;

       public ChessField(int x, int y)
       {
           this.x = x;
           this.y = y; 
       }

       public bool IsFieldWhite()
       {
           throw new NotImplementedException();
       }

       public ICoordinates GetCoordinates()
       {
           throw new NotImplementedException();
       }

       public bool HasFigure()
       {
           throw new NotImplementedException();
       }

       public void SetFigure(IFigure figure)
       {
           throw new NotImplementedException();
       }

       public IFigure GetFigure()
       {
           throw new NotImplementedException();
       }
    }
}
