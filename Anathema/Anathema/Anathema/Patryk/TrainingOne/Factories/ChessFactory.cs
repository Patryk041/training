using System;
using System.Collections.Generic;
using Anathema.Patryk.TrainingOne.Chess;
using Anathema.Patryk.TrainingOne.Chess.Abstract;

namespace Anathema.Patryk.TrainingOne.Factories
{
    public class ChessFactory : AbstractFactory<string,IFigure>
    {
        public ChessFactory()
        {
            Dictonary = new Dictionary<string, Func<IFigure>>()
            {
                {"Bishop", () => new Bishop()},
                {"King", () => new King()},
                {"Queen", () => new Queen()}
            };
        }
    }
}