using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Interfaces.chess
{
    public interface IBoardField
    {
        bool IsFieldWhite();

        ICoordinates GetCoordinates();

        bool HasFigure();

        void SetFigure(IFigure figure);

        IFigure GetFigure();
    }
}
