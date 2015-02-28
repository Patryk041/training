using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame.Figures
{
    public class HorseFigure : ChessFigure
    {
        public HorseFigure( int x, int y, bool isWHite) : base( x, y, isWHite)
        {
            this.figureKind = FigureKind.Horse;
            this.isWhite = isWHite;
            this.coordinates = new ChessCoordinates(x, y);
        }
    }
}
