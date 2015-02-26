using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Sito._2.concretefigures;
using InitialTrainingLibrary.Sito._2.figuressets;

namespace InitialTrainingLibrary.Sito._2
{
    public static class FiguresFactory
    {
        public static Dictionary<FigureKind, Func<bool,FigureSet>> figuresMap = new Dictionary<FigureKind, Func<bool,FigureSet>>()
        {
            {FigureKind.King,(iswhite)=>new KingFigure(iswhite)},
            {FigureKind.Queen,(iswhite)=>new QueenFigure(iswhite)},
            {FigureKind.Bishop,(iswhite)=>new BishopFigure(iswhite)},
            {FigureKind.Rook,(iswhite)=>new RookFigure(iswhite)},
            {FigureKind.Pawn,(iswhite)=>new PawnFigure(iswhite)},
            {FigureKind.Horse,(iswhite)=>new HorseFigure(iswhite)}
        };

        public static FigureSet GetFigureSet(FigureKind figureKind,bool isWhite)
        {
            return figuresMap[figureKind](isWhite);
        }
    }
}
