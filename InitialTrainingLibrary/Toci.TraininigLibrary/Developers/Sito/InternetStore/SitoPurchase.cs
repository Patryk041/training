using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Sito.InternetStore
{
    class SitoPurchase:IPurchase
    {
        private int count;
        private double price;
        private string name;
        private IDiscount discount;
        private bool isDiscount;
        private string productId;


        public int Count()
        {
            return count;
        }

        public double Price()
        {
            return price;
        }

        public string Name()
        {
            return name;
        }

        public IDiscount Discount()
        {
            return isDiscount ? discount : null;
        }

        public string ProductId()
        {
            return productId;
        }

        public bool IsDiscount()
        {
            return isDiscount;
        }
    }
}
