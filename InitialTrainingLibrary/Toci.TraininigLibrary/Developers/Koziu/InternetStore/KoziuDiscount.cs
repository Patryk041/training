using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Koziu.InternetStore
{
    public class KoziuDiscount : IDiscount
    {
        private readonly string _productId;
        private readonly double _discount;

        public KoziuDiscount(string productId, double discount)
        {
            _productId = productId;
            _discount = discount;
        }

        public string ProductId()
        {
            return _productId;
        }

        public double Discount()
        {
            return _discount;
        }
    }
}
