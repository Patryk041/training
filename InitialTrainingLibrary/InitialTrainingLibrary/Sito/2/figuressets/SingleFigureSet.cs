using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2.figuressets
{
    public abstract class SingleFigureSet:FigureSet
    {
        
        public Figure figure;
        public override IFigure GetFigureByCoordinates(ICoordinates coordinates)
        {
            return figure.GetCoordinates()==coordinates ? figure : null;
        }
    }
}
