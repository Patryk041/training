using System;
using System.Collections.Generic;
using Toci.Hornets.Cars;
using Toci.Hornets.Cars.Abstract;

namespace Toci.Hornets.Factories
{
    public class CarFactory
    {
        private Dictionary<string, Func<ICar>> _dictonary;

       /* public CarFactory()
        {
            _dictonary = new Dictionary<string, ICar>()
            {
                {"Honda", GetAnotherCar3()},
                {"Fiat", GetAnotherCar2()},
                {"Ford", GetAnotherCar()}
            };
        }*/

        public CarFactory()
        {
            _dictonary = new Dictionary<string, Func<ICar>>()
            {
                {"Honda", () => new Honda()},
                {"Fiat", () => new Fiat()},
                {"Ford", () => new Ford() }
            };
        }

        private ICar GetAnotherCar()
        {
            return new Ford();
        }
        
        private ICar GetAnotherCar2()
        {
            return new Fiat();
        }
        
        private ICar GetAnotherCar3()
        {
            return new Honda();
        }

        public ICar GetCar(string key)
        {
            Func<ICar> func = _dictonary[key];
            return func();

        }
    }
}