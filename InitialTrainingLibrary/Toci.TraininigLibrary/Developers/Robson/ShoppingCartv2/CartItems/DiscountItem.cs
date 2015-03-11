using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2.CartItems
{
    class DiscountItem : IDiscount
    {
        private int itemId;
        private double discountValue;

        //  konstruktor, który jest wywoływany przy tworzeniu instancji reprezentującej całkowity rabat koszyka.
        public DiscountItem(double discountSummary)
        {
            itemId = 0;
            discountValue = discountSummary;
        }

        //  Zasada jest taka, że ostatni element koszyka, który spełnia warunek promocji, sprzedawany jest za pół ceny.
        public DiscountItem(int itemId, double price) 
        {
            this.itemId = itemId;
            this.discountValue = 0.5 * price;
        }
        public string ProductId()
        {
            return itemId.ToString();
        }

        public double Discount()
        {
            return discountValue;
        }
    }
}
