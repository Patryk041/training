using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2.CartItems
{
    public class Book : Item
    {
        private string author;
        private string title;

        public Book(int id, double price, string author, string title, int howMany)
        {
            this.itemId = id;
            this.price = price;
            this.author = author;
            this.title = title;
            this.name = string.Format("{0}: \"{1}\"", author, title);
            this.howMany = howMany;
            if(howMany >= 3)
            {
                this.discount = new DiscountItem(id, price);
                this.isDiscount = true;
            }
        }


        public override int Count()
        {
            return howMany;
        }

        public override double Price()
        {
            if (discount == null)
            {
                return howMany * price;
            }
            else
            {
                return howMany * price - discount.Discount();
            }
        }

        public override string Name()
        {
            return name;
        }

        public override IDiscount Discount()
        {
            return discount;
        }

        public override string ProductId()
        {
            return itemId.ToString();
        }

        public override bool IsDiscount()
        {
            return isDiscount;
        }
    }
}
