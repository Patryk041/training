using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public abstract class Figure : IFigure
   {
       protected string FigureName;
       protected int FigureX;
       protected int FigureY;

       public Figure(int x, int y, string name)  //lokalizacja figury na planszy (każda figura musi mieć) 
       {
           this.FigureX = x;
           this.FigureY = y;
           this.FigureName = name; 
       }

       public void FigureMove()
       {
           throw new NotImplementedException();
       }

       public bool IsFigureWhite()
       {
           throw new NotImplementedException();
       }

       public ICoordinates GetCoordinates()
       {
           throw new NotImplementedException();
       }

       public FigureKind GetFigureKind()
       {
           throw new NotImplementedException();
       }

       public bool Move(ICoordinates newCoordinates)
       {
           throw new NotImplementedException();
       }
   }
}
