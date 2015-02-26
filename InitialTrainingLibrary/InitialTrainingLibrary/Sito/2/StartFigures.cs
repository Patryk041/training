using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    class StartFigures
    {
        //TODO uzupełnić resztę koordynatów
        private static Dictionary<FigureKind, Func<bool,int, ICoordinates>> fugureCoordinatesByFigureKind = new Dictionary<FigureKind, Func<bool,int, ICoordinates>>
        {
            {FigureKind.Queen,((isWhite,id) => isWhite ? new Coordinates(0,3) : new Coordinates(7,3))},
            {FigureKind.King,((isWhite,id) => isWhite ? new Coordinates(0,4) : new Coordinates(7,4))},
            {FigureKind.Pawn,((isWhite,id) => isWhite ? new Coordinates(1,id-8) : new Coordinates(6,id-8))},
            {FigureKind.Rook,((isWhite,id) => isWhite ? new Coordinates(0,CoorById[FigureKind.Rook](id)) : new Coordinates(7,CoorById[FigureKind.Rook](id)))},
            {FigureKind.Horse,((isWhite,id) => isWhite ? new Coordinates(0,CoorById[FigureKind.Horse](id)) : new Coordinates(7,CoorById[FigureKind.Horse](id)))},
            {FigureKind.Bishop,((isWhite,id) => isWhite ? new Coordinates(0,CoorById[FigureKind.Bishop](id)) : new Coordinates(7,CoorById[FigureKind.Bishop](id)))}

        };

        private static Dictionary<FigureKind, Func<int, int>> CoorById = new Dictionary<FigureKind, Func<int, int>>()
        {
            {FigureKind.Rook, (id) => id == 0 ? 0 : 7},
            {FigureKind.Horse, (id) => id == 0 ? 1 : 6},
             {FigureKind.Bishop, (id) => id == 0 ? 2 : 5},
        };
        public static ICoordinates GetStartFigureCoordinates(FigureKind figure,bool isWhite,int figureId)
        {
            return fugureCoordinatesByFigureKind[figure](isWhite, figureId);
        }
        
    }
}
