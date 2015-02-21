using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Interfaces.chess
{
    public interface IFigure
    {
        bool IsFigureWhite();

        ICoordinates GetCoordinates();

        FigureKind GetFigureKind();

        bool Move(ICoordinates newCoordinates);
    }
}
