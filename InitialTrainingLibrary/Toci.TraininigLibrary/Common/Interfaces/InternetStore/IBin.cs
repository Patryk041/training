using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Interfaces.InternetStore
{
    public interface IBin
    {
        Dictionary<string, IPurchase> Purchases();

        string DevNickName();

        IDiscount GetDiscount();
    }
}
