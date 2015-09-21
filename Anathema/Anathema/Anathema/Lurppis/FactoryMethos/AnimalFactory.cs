using System;
using System.Collections.Generic;
using Anathema.Lurppis.FactoryMethos.Abstract;
using Anathema.Lurppis.FactoryMethos.Abstract.AbstractFactory;
using Anathema.Lurppis.FactoryMethos.Interface;
using Anathema.Lurppis.FactoryMethos.Zwierzeta;

namespace Anathema.Lurppis.FactoryMethos
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