using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Dysq.Bin
{
    public class DysqBin : BinBase
    {
        private Dictionary<string, IPurchase> purchases; 

        public DysqBin()
        {
            purchases = new Dictionary<string, IPurchase>();
        }

        public void AddToDysqBin(IPurchase dysqItem)
        {
            purchases.Add(dysqItem.Name(), dysqItem);
        }

        public override Dictionary<string, IPurchase> Purchases()
        {
            return purchases;
        }

        public override string DevNickName()
        {
            return "Dysq";
        }

        public override IDiscount GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
