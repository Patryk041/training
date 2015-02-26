using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2.figuressets
{
    public abstract class FigureSet
    {
        public abstract IFigure GetFigureByCoordinates(ICoordinates coordinates );
    }
}
