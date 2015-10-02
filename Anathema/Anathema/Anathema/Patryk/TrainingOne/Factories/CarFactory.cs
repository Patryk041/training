     using System;
using System.Collections.Generic;
using Anathema.Patryk.TrainingOne.Cars;
using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Factories
{
    public class CarFactory : AbstractFactory<string,ICar>
    {

        public CarFactory()
        {
            Dictonary = new Dictionary<string, Func<ICar>>()
            {
                {"Honda", () => new Honda()},
                {"Fiat", () => new Fiat()},
                {"Ford", () => new Ford()}
            };
        }
    }
}