using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess.Figures
{
    class King : Figure
    {
       
       public King(int x, int y,bool isWhite)
        {
        this.figureKind = FigureKind.King;
        this.isWhite = isWhite;
        this.coordinates = new Coordinates(x,y);

        }
        
        
    }
}
