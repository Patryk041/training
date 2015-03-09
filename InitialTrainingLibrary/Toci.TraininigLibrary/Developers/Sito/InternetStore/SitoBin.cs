using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Sito.InternetStore
{
    class SitoBin:BinBase
    {
        private Dictionary<string, IPurchase> purchases; 
        public SitoBin()
        {
            purchases = new Dictionary<string, IPurchase>();
        }
        public override Dictionary<string, IPurchase> Purchases()
        {
            return purchases;
        }

        public override string DevNickName()
        {
            return "Sito";
        }

        public override IDiscount GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
