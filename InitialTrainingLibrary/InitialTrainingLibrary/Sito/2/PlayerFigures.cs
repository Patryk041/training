using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Sito._2.figuressets;
using InitialTrainingLibrary.Sito._2.interfaces;

namespace InitialTrainingLibrary.Sito._2
{
    public class PlayerFigures:IPlayerFigures
    {

        private bool isFiguresSetWhite;
        private Dictionary<FigureKind, FigureSet> allFigures = new Dictionary<FigureKind, FigureSet>();

        public PlayerFigures(bool isSetWhite=true)
        {
            isFiguresSetWhite = isSetWhite;
            allFigures.Add(FigureKind.King,FiguresFactory.GetFigureSet(FigureKind.King, isSetWhite));
            allFigures.Add(FigureKind.Pawn, FiguresFactory.GetFigureSet(FigureKind.Pawn, isSetWhite));
            allFigures.Add(FigureKind.Queen, FiguresFactory.GetFigureSet(FigureKind.Queen, isSetWhite));
            allFigures.Add(FigureKind.Horse, FiguresFactory.GetFigureSet(FigureKind.Horse, isSetWhite));
            allFigures.Add(FigureKind.Bishop, FiguresFactory.GetFigureSet(FigureKind.Bishop, isSetWhite));
            allFigures.Add(FigureKind.Rook, FiguresFactory.GetFigureSet(FigureKind.Rook, isSetWhite));
        }
        public bool IsFiguresSetWhite()
        {
            return isFiguresSetWhite;
        }

        public IFigure GetKing()
        {
            return ((SingleFigureSet)allFigures[FigureKind.King]).figure;
        }

        public IFigure GetQueen()
        {
            return ((SingleFigureSet)allFigures[FigureKind.Queen]).figure;
        }

        public IEnumerable<IFigure> GetBishops()
        {
            return ((MultipleFigureSet)allFigures[FigureKind.Bishop]).figures;
        }

        public IEnumerable<IFigure> GetRooks()
        {
            return ((MultipleFigureSet)allFigures[FigureKind.Rook]).figures;
        }

        public IEnumerable<IFigure> GetPawns()
        {
            return ((MultipleFigureSet)allFigures[FigureKind.Pawn]).figures;
        }

        public IFigure GertFigureByCoordinates(ICoordinates coordinates )
        {
            return allFigures.Select(set => set.Value.GetFigureByCoordinates(coordinates)).FirstOrDefault(ret => ret != null);
        }
    }
}
