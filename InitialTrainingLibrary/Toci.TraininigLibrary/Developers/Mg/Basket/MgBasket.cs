using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Mg.Basket
{
   public class MgBasket :BinBase
    {
       
        private Dictionary<string,IPurchase> _itemsList = new Dictionary<string, IPurchase>(); 

        public override Dictionary<string, IPurchase> Purchases()
        {
           return _itemsList;
        }

       public void AddItemToBasket(IPurchase item)
       {
           _itemsList.Add(item.Name(),item);
       }

        public override string DevNickName()
        {
            return "Mg";
        }

        public override IDiscount GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
