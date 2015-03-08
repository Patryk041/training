using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Robson.ShoppingCart
{
    class CartItem<T> : IPurchase where T : Item 
    {
        private List<T> itemList;

        public CartItem()
        {
            itemList = new List<T>();
        }

        public void AddItem(T item)
        {
            itemList.Add(item);
        }

        public int Count()
        {
            return itemList.Count;
        }

        public double Price()
        {
            float price = 0;
            foreach(T item in itemList)
            {
                price += item.GetPrice();
            }
            return price;
        }

        public string Name()
        {
            return itemList.GetType().ToString();
        }

        public IDiscount Discount()
        {
            throw new NotImplementedException();
        }

        public string ProductId()
        {
            return itemList.First().GetId().ToString();
        }

        public bool IsDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
