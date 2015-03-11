using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCart
{
    public abstract class Item 
    {
        protected int itemId;
        protected float price;
        protected ItemType type;

        public Item() { }

        public float GetPrice()
        {
            return price;
        }

        public int GetId()
        {
            return itemId;
        }
    }
}
