using System;
using System.Collections.Generic;

namespace Anathema.adhed.DesignPatterns.FactoryTraining.Factories
{
    public class SmartphoneFactory : AbstractFactory<string, ISmartphone>
    {
        public SmartphoneFactory()
        {
            Dictionary = new Dictionary<string, Func<ISmartphone>>()
            {
                {"Htc", () => new Htc()},
                {"Iphone", () => new Iphone()},
                {"Samsung", () => new Iphone()},
                {"Xiaomi", () => new Xiaomi()}
            };
        }
    }
}