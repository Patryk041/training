using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Bin.DysqBase
{
    public class Boots
    {
        protected int ProductId;
        protected BootKind Name;
        protected double Price;
        protected bool Discount;
        
        protected int Quantity;

        protected Boots(int productId, BootKind name, double price, bool discount)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Discount = discount;

        }

        public void SetQuantity( int howMany)
        {
            Quantity = howMany;
        }

    }
}
