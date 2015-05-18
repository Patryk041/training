using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    static class CoouseyFigureFactory
    {
        private static readonly Dictionary<FigureKind, Func<bool, CoouseyCoordinates, FigureKind, IFigure>> FigureFactoryDirectory 
            = new Dictionary <FigureKind, Func<bool, CoouseyCoordinates, FigureKind, IFigure>>
       {
           {FigureKind.Pawn, (isWhite, coordinates, figureKind) => new CoouseyPawn(isWhite, coordinates, figureKind)},
           {FigureKind.Rook, (isWhite, coordinates, figureKind) => new CoouseyRook(isWhite, coordinates, figureKind)},
           {FigureKind.Horse, (isWhite, coordinates, figureKind) => new CoouseyHorse(isWhite, coordinates, figureKind)},
           {FigureKind.Bishop, (isWhite, coordinates, figureKind) => new CoouseyBishop(isWhite, coordinates, figureKind)},
           {FigureKind.Queen, (isWhite, coordinates, figureKind) => new CoouseyQueen(isWhite, coordinates, figureKind)},
           {FigureKind.King, (isWhite, coordinates, figureKind) => new CoouseyKing(isWhite, coordinates, figureKind)}         
       };

        public static IFigure GetNewFigure(bool isWhite, CoouseyCoordinates coordinates, FigureKind figureKind)
        {
            return FigureFactoryDirectory[figureKind](isWhite, coordinates, figureKind);
        }
    }
}
