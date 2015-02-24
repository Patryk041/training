using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    class StartFiguresCoordinates
    {
        //TODO uzupełnić resztę koordynatów
        private static Dictionary<FigureKind, Func<bool,int, ICoordinates>> fugureCoordinatesByFigureKind = new Dictionary<FigureKind, Func<bool,int, ICoordinates>>
        {
            {FigureKind.King,((isWhite,id) => isWhite ? new Coordinates(0,4+id) : new Coordinates(8,4+id))},
            {FigureKind.Pawn,((isWhite,id) => isWhite ? new Coordinates(1,0+id) : new Coordinates(2,0+id))},
        };
        public static ICoordinates GetStartFigureCoordinates(FigureKind figure,bool isWhite,int figureId)
        {
            return fugureCoordinatesByFigureKind[figure](isWhite,figureId);
        }
    }
}
