using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingTwo.Generics.Factory.ChessFigures
{
    public static class CarsFactory
    {
        private static Dictionary<FigureType, Figure> figures = new Dictionary<FigureType, Figure>()
        {
            {FigureType.Bishop, new Bishop()}
        };

        public static Figure GetFigure(FigureType type)
        {
            return figures.ContainsKey(type) ? figures[type] : null;
        }
    }
}