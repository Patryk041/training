using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board.Figures
{
   public class Horse : ChessFigures
    {
       

       public Horse(int x, int y, bool isWhite)
       {
           FigureKind = FigureKind.Horse;
           this.Cooridnate = new Cooridnate(x, y);
           this.IsWhite = isWhite; 
       }
    }
}
