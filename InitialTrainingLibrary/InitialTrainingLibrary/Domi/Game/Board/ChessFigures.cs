using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Domi.Game.Board.Figures;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.RS.Chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public abstract class ChessFigures : IFigure
   {
       protected FigureKind FigureKind;

       public ChessFigures()
       { }

       public ChessFigures(FigureKind figureKind)  //lokalizacja figury na planszy (każda figura musi mieć) 
       {
           this.FigureKind = figureKind;
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
           return ChessFactory.CreateFigure(FigureKind).GetFigureKind();
           //zwracal zmienna w konstruktorze ktora bedziesz budizl fabryke 
       }

       public bool Move(ICoordinates newCoordinates)
       {
           throw new NotImplementedException();
       }
   }
}
