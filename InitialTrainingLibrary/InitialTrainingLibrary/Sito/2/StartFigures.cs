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
            {FigureKind.Queen,((isWhite,id) => isWhite ? new Coordinates(3,0) : new Coordinates(3,7))},
            {FigureKind.King,((isWhite,id) => isWhite ? new Coordinates(4,0) : new Coordinates(4,7))},
            {FigureKind.Pawn,((isWhite,id) => isWhite ? new Coordinates(id-8,1) : new Coordinates(id-8,6))},
            {FigureKind.Rook,((isWhite,id) => isWhite ? new Coordinates(CoorById[FigureKind.Rook](id),0) : new Coordinates(CoorById[FigureKind.Rook](id),7))},
            {FigureKind.Horse,((isWhite,id) => isWhite ? new Coordinates(CoorById[FigureKind.Horse](id),0) : new Coordinates(CoorById[FigureKind.Horse](id),7))},
            {FigureKind.Bishop,((isWhite,id) => isWhite ? new Coordinates(CoorById[FigureKind.Bishop](id),0) : new Coordinates(CoorById[FigureKind.Bishop](id),7))}

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
