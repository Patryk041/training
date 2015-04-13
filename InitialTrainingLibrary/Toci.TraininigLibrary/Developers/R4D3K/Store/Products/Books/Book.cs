using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.R4D3K.Store.ProductBase;
namespace Toci.TraininigLibrary.Developers.R4D3K.Store.Products.Books
{
    class Book : Product
    {
        public List<KindOfBook> BookCategory { get; set; }
        protected Book(int id, string name, int count, decimal price, ProductDiscount discount,ProductCategory cat) : base(id, name, count, price, discount,cat)
        {
            this.Id = id;
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.Discount = discount;
            this.Category = cat;
            BookCategory = new List<KindOfBook>();
        }
    }
}
