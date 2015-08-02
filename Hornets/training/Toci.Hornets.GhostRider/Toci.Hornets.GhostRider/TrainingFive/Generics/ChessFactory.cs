using System;
using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingFive.Generics
{
    public class ChessFactory : RegularFactory<IChessFigure>
    {
        public ChessFactory()
        {
            this.factoryItemsList = new Dictionary<string, Func<IChessFigure>>
            {
                //{ "king", }
            };
        }
    }
}