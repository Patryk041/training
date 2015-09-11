using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Igor.AbstractFactory.Computers;

namespace Anathema.Igor.AbstractFactory.ComputerFactory
{
    public class ComputerFactory : AbstractFactory<string, IComputer>
    {
        public ComputerFactory()
        {
            dictionary = new Dictionary<string, Func<IComputer>>
            {
                {"Acer", () => new Acer()},
                {"Apple", () => new Apple()},
                {"ASUS", () => new ASUS()},
                {"Dell", () => new Dell()},
                {"HP", () => new HP()},
                {"Logitech", () => new Logitech()},
                {"Samsung", () => new Samsung()},
                {"Sony", () => new Sony()}
            };
        }
    }
}
