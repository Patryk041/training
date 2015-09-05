using System;
using System.Collections.Generic;
using Toci.Hornets.Cars;
using Toci.Hornets.Cars.Abstract;

namespace Toci.Hornets.Factories
{
    public class CarFactory
    {
        private Dictionary<string, ICar> _dictonary;

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
            _dictonary = new Dictionary<string, ICar>()
            {
                {"Honda", GetAnotherCar3()},
                {"Fiat", GetAnotherCar2()},
                {"Ford", GetAnotherCar()}
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
            return _dictonary[key];
        }
    }
}