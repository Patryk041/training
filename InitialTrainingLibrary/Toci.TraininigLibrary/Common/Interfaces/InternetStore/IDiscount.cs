using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Interfaces.InternetStore
{
    public interface IDiscount
    {
        string ProductId();

        double Discount();
    }
}
