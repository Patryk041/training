using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2.CartItems
{
    public abstract class Item : IPurchase
    {
        protected int itemId;
        protected double price;
        protected string name;
        protected IDiscount discount;
        protected int howMany;
        protected bool isDiscount;


        public abstract int Count();

        public abstract double Price();

        public abstract string Name();

        public abstract IDiscount Discount();

        public abstract string ProductId();

        public abstract bool IsDiscount();
    }
}
