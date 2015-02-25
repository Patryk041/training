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
            {FigureKind.Pawn,((isWhite,id) => isWhite ? new Coordinates(1,0+id) : new Coordinates(6,0+id))},
            {FigureKind.Rook,((isWhite,id) => isWhite ? new Coordinates(0,0+id) : new Coordinates(7,0+id+6))},
            {FigureKind.Horse,((isWhite,id) => isWhite ? new Coordinates(0,0+id+1) : new Coordinates(7,0+id+5))},
            {FigureKind.Bishop,((isWhite,id) => isWhite ? new Coordinates(0,0+id+2) : new Coordinates(7,0+id+4))},
        };
        public static ICoordinates GetStartFigureCoordinates(FigureKind figure,bool isWhite,int figureId)
        {
            return fugureCoordinatesByFigureKind[figure](isWhite,figureId);
        }
        
    }
}
