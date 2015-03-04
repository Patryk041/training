using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.Bin.DysqBase;

namespace Toci.TraininigLibrary.Developers.Dysq.Bin.Products
{
    public class HighHeelBoots : Boots
    {
        protected HighHeelBoots(int productId, BootKind name, double price, bool discount) : 
            base(productId, name, price, discount)
        {
        }
    }
}
