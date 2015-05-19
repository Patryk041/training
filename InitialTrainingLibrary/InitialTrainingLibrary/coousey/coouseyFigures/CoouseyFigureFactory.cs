using System;
using System.Collections.Generic;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyFigureFactory
    {
        private const int WhitePawnRow = 1;
        private const int BlackPawnRow = 6;
        private const int WhiteMainRow = 0;
        private const int BlacMainRow = 7;

        private const int LeftRookColumn = 0;
        private const int RightRookColumn = 7;
        private const int LeftHorseColumn = 1;
        private const int RightHorseColumn = 6;
        private const int LeftBishopColumn = 2;
        private const int RightBishopColumn = 5;
        private const int QueenColumn = 3;
        private const int KingColumn = 4;

        private static readonly Dictionary<FigureKind, Func<CoouseyCoordinates, IFigure>> FigureFactoryDirectory
            = new Dictionary<FigureKind, Func<CoouseyCoordinates, IFigure>>
       {
           {FigureKind.Pawn, coordinates => new CoouseyPawn(coordinates, FigureKind.Pawn)},
           {FigureKind.Rook, coordinates => new CoouseyRook(coordinates, FigureKind.Rook)},
           {FigureKind.Horse, coordinates => new CoouseyHorse(coordinates, FigureKind.Horse)},
           {FigureKind.Bishop, coordinates => new CoouseyBishop(coordinates, FigureKind.Bishop)},
           {FigureKind.Queen, coordinates => new CoouseyQueen(coordinates, FigureKind.Queen)},
           {FigureKind.King, coordinates => new CoouseyKing(coordinates, FigureKind.King)} 
       };

        public static IFigure GetNewFigure(CoouseyCoordinates coordinates)
        {
            if (CoordinatesToFigureKind(coordinates) == 0) return null;
            return FigureFactoryDirectory[CoordinatesToFigureKind(coordinates)](coordinates);
        }

        private static readonly Func<ICoordinates, FigureKind> CoordinatesToFigureKind = coordinates =>
        {
            switch (coordinates.GetY())
            {
                case WhitePawnRow:
                case BlackPawnRow:
                    return FigureKind.Pawn;
                case WhiteMainRow:
                case BlacMainRow:
                    switch (coordinates.GetX())
                    {
                        case LeftRookColumn:
                        case RightRookColumn:
                            return FigureKind.Rook;
                        case LeftHorseColumn:
                        case RightHorseColumn:
                            return FigureKind.Horse;
                        case LeftBishopColumn:
                        case RightBishopColumn:
                            return FigureKind.Bishop;
                        case QueenColumn:
                            return FigureKind.Queen;
                        case KingColumn:
                            return FigureKind.King;
                    }
                    break;
            }
            return 0;
        };
    }
}
