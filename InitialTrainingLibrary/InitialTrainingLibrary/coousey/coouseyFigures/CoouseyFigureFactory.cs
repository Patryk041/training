using System;
using System.Collections.Generic;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyFigureFactory
    {
        private const int WhitePawnRow = 1;
        private const int BlackPawnRow = 6;
        private const int WhiteMainRow = 0;
        private const int BlackMainRow = 7;

        private const int LeftRookColumn = 0;
        private const int RightRookColumn = 7;
        private const int LeftHorseColumn = 1;
        private const int RightHorseColumn = 6;
        private const int LeftBishopColumn = 2;
        private const int RightBishopColumn = 5;
        private const int QueenColumn = 3;
        private const int KingColumn = 4;

        private const int UpperBlackRow = 5;

        private static readonly Dictionary<FigureKind, Func<ICoordinates, bool, IFigure>> FigureFactoryDirectory
            = new Dictionary<FigureKind, Func<ICoordinates, bool, IFigure>>
       {
           {FigureKind.Pawn, (coordinates, isWhite) => isWhite
               ? (CoouseyFigure) (new CoouseyWhitePawn(coordinates, FigureKind.Pawn, true))
               : (CoouseyFigure) (new CoouseyBlackPawn(coordinates, FigureKind.Pawn, false))
           },
           {FigureKind.Rook, (coordinates, isWhite) => new CoouseyRook(coordinates, FigureKind.Rook, isWhite)},
           {FigureKind.Horse, (coordinates, isWhite) => new CoouseyHorse(coordinates, FigureKind.Horse, isWhite)},
           {FigureKind.Bishop, (coordinates, isWhite) => new CoouseyBishop(coordinates, FigureKind.Bishop, isWhite)},
           {FigureKind.Queen, (coordinates, isWhite) => new CoouseyQueen(coordinates, FigureKind.Queen, isWhite)},
           {FigureKind.King, (coordinates, isWhite) => new CoouseyKing(coordinates, FigureKind.King, isWhite)} 
       };

        // for tests only
        public static IFigure GetNewFigureByKind(FigureKind kind,ICoordinates coordinates, bool isWhite)
        {
            return FigureFactoryDirectory[kind](coordinates, isWhite);
        }

        public static IFigure GetNewFigureForCoordinate(ICoordinates coordinates)
        {
            var isWhite = coordinates.GetY() < UpperBlackRow;

            switch (coordinates.GetY())
            {
                case WhitePawnRow:
                case BlackPawnRow:
                    return FigureFactoryDirectory[FigureKind.Pawn](coordinates, isWhite);

                case WhiteMainRow:
                case BlackMainRow:
                    switch (coordinates.GetX())
                    {
                        case LeftRookColumn:
                        case RightRookColumn:
                            return FigureFactoryDirectory[FigureKind.Rook](coordinates, isWhite);

                        case LeftHorseColumn:
                        case RightHorseColumn:
                            return FigureFactoryDirectory[FigureKind.Horse](coordinates, isWhite);

                        case LeftBishopColumn:
                        case RightBishopColumn:
                            return FigureFactoryDirectory[FigureKind.Bishop](coordinates, isWhite);

                        case QueenColumn:
                            return FigureFactoryDirectory[FigureKind.Queen](coordinates, isWhite);

                        case KingColumn:
                            return FigureFactoryDirectory[FigureKind.King](coordinates, isWhite);

                        default:
                            throw new Exception("wrong Coordinates, out of bounds");
                    }
                default:
                    return null;
            }
        }
    }
}

