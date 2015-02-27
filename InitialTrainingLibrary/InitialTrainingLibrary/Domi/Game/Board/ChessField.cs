using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Board;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessField : IBoardField    //pola gry szachy 
    {  
       
       protected int X;
       protected int Y;
       protected ICoordinates getPossition;

       public ChessField(int x, int y)
       {
          getPossition = new Cooridnate(x,y); //powołujemy współrzędne 
       }
      
       public ICoordinates GetCoordinates()
       {
           return getPossition; //pozycja 
       }
      
       public bool IsFieldWhite()
       {
           return ((getPossition.GetX() + getPossition.GetY())%2 == 0); //sprawdzamy czy pole jest białe 
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
