using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.Store.Interfaces;

namespace Toci.TraininigLibrary.Developers.R4D3K.Store.ProductBase
{
    public abstract class Product : IProduct
    {
        public int Id { get; set; }
        protected string Name { get; set; }
        protected int Count { get; set; }
        protected decimal Price { get; set; }
        protected ProductDiscount Discount { get; set; }
        protected ProductCategory Category { get; set; }
        protected Product(int id, string name, int count, decimal price, ProductDiscount discount,ProductCategory cat)
        {

        }
        protected int Rank { get; set; }
        
    }
}
