using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Sito._2.interfaces;

namespace InitialTrainingLibrary.Sito._2
{
    class FiguresSet:IFiguresSet
    {

        private bool isFiguresSetWhite;
        private Figure king;
        private Figure queen;
        private List<Figure> bishops;
        private List<Figure> rooks;
        private List<Figure> pawns;

        public FiguresSet(bool isSetWhite=true)
        {
            //TODO stworzyć kolejne figury
            king = new Figure(isSetWhite, FigureKind.King);
        }
        public bool IsFiguresSetWhite()
        {
            return isFiguresSetWhite;
        }

        public IFigure GetKing()
        {
            return king;
        }

        public IFigure GetQueen()
        {
            return queen;
        }

        public IEnumerable<IFigure> GetBishops()
        {
            return bishops;
        }

        public IEnumerable<IFigure> GetRooks()
        {
            return rooks;
        }

        public IEnumerable<IFigure> GetPawns()
        {
            return pawns;
        }
    }
}
