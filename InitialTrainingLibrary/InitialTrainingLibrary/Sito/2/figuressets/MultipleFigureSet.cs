using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2.figuressets
{
    public abstract class MultipleFigureSet:FigureSet
    {
        public List<Figure> figures;

        public override IFigure GetFigureByCoordinates(ICoordinates coordinates)
        {
            return figures.FirstOrDefault(figure => figure.GetCoordinates() == coordinates);
        }
    }
}
