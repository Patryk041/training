using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingTwo.Generics.Factory.ChessFigures
{
    public class ChessFiguresGenericFactory : GenericFactory<FigureType, Figure>
    {
        public ChessFiguresGenericFactory()
        {
            items = new Dictionary<FigureType, Figure>()
            {
                {FigureType.Bishop, new Bishop()}
            };
        }
    }
}