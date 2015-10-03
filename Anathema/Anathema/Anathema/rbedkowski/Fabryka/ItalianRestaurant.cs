using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Fabryka
{
    public class ItalianRestaurant :IRestaurant
    {
        public IOrder GetComponent()
        {
            return new Pizza();
        }
    }
}
