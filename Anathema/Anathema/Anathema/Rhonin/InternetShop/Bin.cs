using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Rhonin.InternetShop
{
    public class Bin
    {
        Dictionary<string,Purchase> purchases = new Dictionary<string, Purchase>();

        public string DevNickName()
        {
            return "Rhonin";
        }

        public Discount GeDiscount()
        {
            return new Discount();
        }
    }
}
