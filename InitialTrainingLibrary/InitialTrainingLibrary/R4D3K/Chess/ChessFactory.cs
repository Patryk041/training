using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.R4D3K.Chess.Figures;

namespace InitialTrainingLibrary.R4D3K.Chess
{
    public static class ChessFactory
    {
        private static Dictionary<FigureKind, Func<int, int, bool, IFigure>> figure = new Dictionary<FigureKind, Func<int, int, bool, IFigure>>()
        {
            {FigureKind.Bishop,(x,y,isWhite)=> new Bishop(x,y,isWhite) },
            {FigureKind.Bishop,(x,y,isWhite)=> new Horse(x,y,isWhite) },
            {FigureKind.Bishop,(x,y,isWhite)=> new King(x,y,isWhite) },
            {FigureKind.Bishop,(x,y,isWhite)=> new Pawn(x,y,isWhite) },
            {FigureKind.Bishop,(x,y,isWhite)=> new Queen(x,y,isWhite) },
            {FigureKind.Bishop,(x,y,isWhite)=> new Rook(x,y,isWhite) }
        };

        public static IFigure CreateFigure(FigureKind kind,int x,int y,bool isWhite)
        {
            return figure[kind](x, y, isWhite);
        }
    }
}
