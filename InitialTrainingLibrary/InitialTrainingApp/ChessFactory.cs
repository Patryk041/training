using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board.Figures
{
   static class ChessFactory
    {
        private static Dictionary<FigureKind, Func<IFigure>> _figureMapDictionary = new Dictionary
          <FigureKind, Func<IFigure>>()
       {
           {FigureKind.Bishop, () => new Bishop()},
           {FigureKind.Horse, () => new Horse()},
           {FigureKind.King, () => new King()},
           {FigureKind.Pawn, () => new Pawn()},
           {FigureKind.Queen, () => new Queen()},
           {FigureKind.Rook, () => new Rook()}
       };

       public static IFigure CreateFigure(FigureKind figureKind)
       {
           return _figureMapDictionary[figureKind]();
       }
    }
}
