using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;
using Toci.TraininigLibrary.Developers.Robson.ShoppingCart.Items;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCart
{
    public class RobsonsShoppingCart : BinBase
    {
        List<CartItem<Book>> allItems;

        public override Dictionary<string, IPurchase> Purchases()
        {
            throw new NotImplementedException();
        }

        public override string DevNickName()
        {
            throw new NotImplementedException();
        }

        public override Common.Interfaces.InternetStore.IDiscount GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
