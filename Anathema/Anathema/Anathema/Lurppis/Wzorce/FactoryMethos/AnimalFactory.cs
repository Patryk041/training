using System;
using System.Collections.Generic;
using Anathema.Lurppis.Wzorce.FactoryMethos.Abstract.AbstractFactory;
using Anathema.Lurppis.Wzorce.FactoryMethos.Interface;
using Anathema.Lurppis.Wzorce.FactoryMethos.Zwierzeta;

namespace Anathema.Lurppis.Wzorce.FactoryMethos
{
    public class AnimalFactory : AbstractAnimkalFactory<string,IAnimal>
    {
        public AnimalFactory()
        {
            Dictionary = new Dictionary<string, Func<IAnimal>>
            {
                {"Cat", () => new Cat()},
                {"Wolf", () => new Wolf() }
                //Można tak w nieskonczonosc
            };
        }
    }
}