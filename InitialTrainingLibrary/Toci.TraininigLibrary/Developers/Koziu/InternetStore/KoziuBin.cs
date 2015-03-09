using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Koziu.InternetStore
{
    public class KoziuBin : BinBase
    {
        
        private readonly Dictionary<string, IPurchase> bikes = new Dictionary<string, IPurchase>(); 

        public override Dictionary<string, IPurchase> Purchases()
        {
            return bikes;
        }

        public override string DevNickName()
        {
            return "Koziu";
        }

        public void AddPurchase(string key, Bike bike)
        {
            bikes.Add(key, bike);
        }

        public override IDiscount GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
