using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;
using Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2.CartItems;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2
{
    public class RobsonsShoppingCart : BinBase
    {
        private Dictionary<string, IPurchase> cartItems;

        public RobsonsShoppingCart()
        {
            cartItems = new Dictionary<string, IPurchase>();
        }

        public override Dictionary<string, IPurchase> Purchases()
        {
            return cartItems;
        }

        public override string DevNickName()
        {
            return "Robson";
        }

        public override IDiscount GetDiscount()
        {
            double discountSummary = 0;
            foreach(var cartItem in cartItems)
            {
                if(cartItem.Value.IsDiscount())
                {
                    discountSummary += cartItem.Value.Discount().Discount();
                }
            }

            return new DiscountItem(discountSummary);
        }

        public void AddCartItem(Item cartItem)
        {
            cartItems.Add(cartItem.Name(), cartItem);
        }

        public double GetCartValue(Dictionary<string, IPurchase> cart)
        {
            double CartValue = 0;

            foreach(var cartItem in cart)
            {
                CartValue += cartItem.Value.Price();
            }

            return CartValue;
        }
    }
}
