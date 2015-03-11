using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.ShoppingCart;
namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCart.Items
{
    public class Book : Item
    {
        private string author;
        private string title;

        public Book(int id, float price, string author, string title)
        {
            this.author = author;
            this.title = title;
            this.price = price;
            this.itemId = id;
            this.type = ItemType.Book;
        }
    }
}
