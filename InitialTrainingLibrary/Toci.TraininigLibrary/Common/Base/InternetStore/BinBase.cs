using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Common.Base.InternetStore
{
    public abstract class BinBase : IBin
    {
        public Dictionary<string, IPurchase> Purchases()
        {
            throw new NotImplementedException();
        }

        public string DevNickName()
        {
            throw new NotImplementedException();
        }

        public IDiscount GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
