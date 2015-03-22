using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Factory
{
    public static class CarFactoryGenerics
    {


        private static Dictionary<string, ICar> CarsList = new Dictionary<string, ICar>
        {
            {"porsche", new Porsche()},
            {"opel", new Opel()},
            {"volkswaGEN", new Volswagen()},
        };

        private static Dictionary<string, Func<ICar>> CarsListDelegate = new Dictionary<string, Func<ICar>>
        {
            {"porsche", () => new Porsche()},
            {"opel", () => new Opel()},
            {"volkswaGEN", () => new Volswagen()},
        };

        public static ICar CreateInstance(string text)
        {
            return CarsListDelegate.ContainsKey(text) ? CarsListDelegate[text]() : null;
            //return CarsList.ContainsKey(text) ? CarsList[text] : null;
        }
    }
}
