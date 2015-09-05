using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Skilloo.Fabryka
{
   public class CarFactory
    {
        private Dictionary<string, Func<ICar>> _dictionary;

        public CarFactory()
        {
            _dictionary= new Dictionary<string, Func<ICar>>()
            {
                {"Golf", () => new Golf() },
                {"Golf1", () => new Golf() }
            };
        }

        public ICar GetCar(string key)
        {
            return _dictionary[key]();
        }

        
    }
}
