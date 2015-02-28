using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Domi.Game.Board.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessFigures : IFigure
   {
       protected FigureKind FigureKind;
       protected bool IsWhite;
       protected Cooridnate Cooridnate; 
      
       public ChessFigures() { }

       public ChessFigures(FigureKind figureKind, bool color)  //lokalizacja figury na planszy (każda figura musi mieć) 
       {
           this.FigureKind = figureKind;
           this.IsWhite = color;
       }

       public void FigureMove()
       {
           throw new NotImplementedException();
       }

       public bool IsFigureWhite()
       {
           return IsWhite; 
       }

       public ICoordinates GetCoordinates()
       {
           return Cooridnate; 
       }

       public FigureKind GetFigureKind()
       {
           return FigureKind;
       }

       public bool Move(ICoordinates newCoordinates)
       {
           throw new NotImplementedException();
       }
   }
}
