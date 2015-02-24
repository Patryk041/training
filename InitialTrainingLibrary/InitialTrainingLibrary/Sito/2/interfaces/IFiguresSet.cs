using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2.interfaces
{
    public interface IFiguresSet
    {
        bool IsFiguresSetWhite();
        IFigure GetKing();
        IFigure GetQueen();
        IEnumerable<IFigure> GetBishops();
        IEnumerable<IFigure> GetRooks();
    }
}
