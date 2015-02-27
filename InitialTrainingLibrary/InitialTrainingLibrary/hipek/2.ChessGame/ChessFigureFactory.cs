using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.hipek._2.ChessGame.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public static class ChessFigureFactory
    {
        private static Dictionary<FigureKind, Func< int, int, bool, IFigure>> _figureMap = new Dictionary<FigureKind, Func< int, int, bool, IFigure>>()
        {
            {FigureKind.Bishop, (x, y, isWhite) => new BishopFigure(x, y, isWhite)},
            {FigureKind.Horse, (x, y, isWhite) => new HorseFigure(x, y, isWhite)},
            {FigureKind.King, (x, y, isWhite) => new KingFigure(x, y, isWhite)},
            {FigureKind.Pawn, (x, y, isWhite) => new PawnFigure(x, y, isWhite)},
            {FigureKind.Queen, (x, y, isWhite) => new QueenFigure(x, y, isWhite)},
            {FigureKind.Rook, (x, y, isWhite) => new RookFigure(x, y, isWhite)}
        };

        public static IFigure CreateFigure(int x, int y, bool isWhite, FigureKind figure)
        {
            
            return _figureMap[figure](x, y, isWhite);
        }
    }
}
