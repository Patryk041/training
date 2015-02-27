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
        private static Dictionary<FigureKind, Func<IFigure>> _figureMap = new Dictionary<FigureKind, Func<IFigure>>()
        {
            {FigureKind.Bishop, () => new BishopFigure()},
            {FigureKind.Horse, () => new HorseFigure()},
            {FigureKind.King, () => new KingFigure()},
            {FigureKind.Pawn, () => new PawnFigure()},
            {FigureKind.Queen, () => new QueenFigure()},
            {FigureKind.Rook, () => new RookFigure()}
        };

        public static IFigure CreateFigure(FigureKind figure)
        {
            return _figureMap[figure]();
        }
    }
}
