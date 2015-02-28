using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Domi.Game.Board.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   static partial class ChessFactory
    {
        private static Dictionary<FigureKind, Func<int,int, bool, IFigure>> _figureMapDictionary = new Dictionary
          <FigureKind, Func<int, int, bool, IFigure>>()
       {
           {FigureKind.Bishop, (x,y, isWhite) => new Bishop(x,y, isWhite)},
           {FigureKind.Horse, (x,y, isWhite) => new Horse(x,y, isWhite)},
           {FigureKind.King, (x,y, isWhite) => new King(x,y, isWhite)},
           {FigureKind.Pawn, (x,y, isWhite) => new Pawn(x,y, isWhite)},
           {FigureKind.Queen, (x,y, isWhite) => new Queen(x,y, isWhite)},
           {FigureKind.Rook, (x,y, isWhite) => new Rook(x,y, isWhite)}
       };

       public static IFigure CreateFigure(int x, int y, bool isWhite,FigureKind figureKind)
       {
           return _figureMapDictionary[figureKind](x,y,isWhite);
       }
    }
}
