using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board.Figures
{
   public class Pawn : ChessFigures
    {
        
   
       public Pawn(int x, int y, bool isWhite)
       {
           this.FigureKind = FigureKind.Pawn;
           this.Cooridnate = new Cooridnate(x, y);
           this.IsWhite = isWhite; 
       }
    }
}
