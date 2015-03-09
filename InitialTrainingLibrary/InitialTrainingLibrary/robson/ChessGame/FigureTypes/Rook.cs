using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.robson.ChessGame;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.robson.ChessGame.FigureTypes
{
    public class Rook : ChessBoardFigure
    {
        public Rook(int x, int y, FigureColor color)
        {
            this.figureColor = color;
            this.figurePosition = new ChessBoardFieldCoordinates(x, y);
            this.figureType = FigureKind.Bishop;
        }
    }
}
