using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.Chess.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.dysq.Chess
{
    public static class FigureFactory
    {
        public static Dictionary<FigureKind, Func<int, int, bool, IFigure>> figureCreator = new Dictionary<FigureKind, Func<int, int, bool, IFigure>>()
        {
            {FigureKind.Bishop, (x,y,colour) => new Bishop(x,y,colour)},
            {FigureKind.Horse, (x,y,colour) => new Horse(x,y,colour)},
            {FigureKind.King, (x,y,colour) => new King(x,y,colour)},
            {FigureKind.Pawn, (x,y,colour) => new Pawn(x,y,colour)},
            {FigureKind.Queen, (x,y,colour) => new Queen(x,y,colour)},
            {FigureKind.Rook, (x,y,colour) => new Rook(x,y,colour)},
        };

        public static IFigure CreateFigure(FigureKind figure, int x, int y, bool colour)
        {
            return figureCreator[figure](x,y,colour);
        }
    }
}
