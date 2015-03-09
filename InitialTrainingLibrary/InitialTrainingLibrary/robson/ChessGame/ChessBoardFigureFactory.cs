using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.robson.ChessGame;
using InitialTrainingLibrary.robson.ChessGame.FigureTypes;

namespace InitialTrainingLibrary.robson.ChessGame
{
    public static class ChessBoardFigureFactory
    {
        public static IFigure MakeFigure(int xCord, int yCord, FigureColor colorValue, FigureKind type)
        {
            Dictionary<FigureKind, Func<int, int, FigureColor, IFigure>> figure = new Dictionary<FigureKind, Func<int, int, FigureColor, IFigure>>()
            {
                {FigureKind.Bishop, (x, y, color)=> new Bishop(x, y, color)},
                {FigureKind.Horse, (x,y,color)=> new Horse(x,y,color)},
                {FigureKind.King, (x,y,color)=> new King(x,y,color)},
                {FigureKind.Pawn, (x,y,color)=> new Pawn(x,y,color)},
                {FigureKind.Queen, (x,y,color)=> new Queen(x,y,color)},
                {FigureKind.Rook, (x,y,color)=> new Rook(x,y,color)}
            };
      
            return figure[type](xCord, yCord, colorValue);
        }
    }
}
