using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Factory
{
    public static class CarFactory
    {
        public static ICar CreateCar(string name)
        {
            switch (name)
            {
                case "Porsche":
                    return new Porsche();
                case "Volkswagen":
                    return new Volswagen();
                default:
                    return new Opel();
            }
        }
    }
}
