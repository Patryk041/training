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
        public abstract Dictionary<string, IPurchase> Purchases();

        public abstract  string DevNickName();

        public abstract IDiscount GetDiscount();
    }
}
