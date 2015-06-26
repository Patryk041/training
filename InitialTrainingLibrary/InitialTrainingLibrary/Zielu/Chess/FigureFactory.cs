using System;
using System.Collections.Generic;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Chess.ZieluFigures;

namespace InitialTrainingLibrary.Zielu.Chess
{
    public static class FigureFactory
    {
        private static readonly Dictionary<FigureKind, Func<bool, ICoordinates, IFigure>> FigureDictionary = new Dictionary
            <FigureKind, Func<bool, ICoordinates, IFigure>>()
        {
            {FigureKind.Bishop, (color,startingPosition) => new ZieluBishop(color,startingPosition)},
            {FigureKind.Horse, (color,startingPosition) => new ZieluHorse(color,startingPosition)},
            {FigureKind.King, (color,startingPosition) => new ZieluKing(color,startingPosition)},
            {FigureKind.Pawn, (color,startingPosition) => new ZieluPawn(color,startingPosition)},
            {FigureKind.Queen, (color,startingPosition) => new ZieluQueen(color,startingPosition)},
            {FigureKind.Rook, (color,startingPosition) => new ZieluRook(color,startingPosition)},
        };

        public static IFigure NewFigure(bool color,ICoordinates startingPosition, FigureKind figure)
        {
            return FigureDictionary.ContainsKey(figure) ? FigureDictionary[figure](color, startingPosition) : null;
        }
    }
}
