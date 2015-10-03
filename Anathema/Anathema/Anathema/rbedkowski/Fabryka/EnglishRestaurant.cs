using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Fabryka
{
    public class EnglishRestaurant : IRestaurant
    {
        public IOrder GetComponent()
        {
            return new Tea();
        }
    }
}
