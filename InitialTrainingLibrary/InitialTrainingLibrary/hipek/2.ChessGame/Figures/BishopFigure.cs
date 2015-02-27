using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame.Figures
{
    public class BishopFigure : ChessFigure
    {
        public BishopFigure( int x, int y, bool isWHite) : base( x, y, isWHite)
        {
            this.figureKind = FigureKind.Bishop;
            this.isWhite = isWHite;
            this.coordinates = new ChessCoordinates(x, y);
        }
    }
}
