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
        private static Dictionary<FigureKind, Func<bool, ICoordinates>> fugureCoordinatesByFigureKind = new Dictionary<FigureKind, Func<bool, ICoordinates>>
        {
            {FigureKind.King,(isWhite => isWhite ? new Coordinates(0,4) : new Coordinates(8,4))}
        };
        public static ICoordinates GetStartFigureCoordinates(FigureKind figure,bool isWhite)
        {
            return fugureCoordinatesByFigureKind[figure](isWhite);
        }
    }
}
