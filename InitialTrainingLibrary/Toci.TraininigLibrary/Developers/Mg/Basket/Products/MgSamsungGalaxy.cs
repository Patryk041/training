using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Mg.Basket.Products
{
    public class MgSamsungGalaxy : IPurchase
    {

        private int _quantity;
        private double _price;
        private string _name;
        private string _productID;
        private bool _isDiscount;

        public MgSamsungGalaxy(int _quantity, double _price, string _name, bool _isDiscount)
        {
            this._quantity = _quantity;
            this._price = _price*_quantity;
            this._name = _name;
            this._productID = _name;
            this._isDiscount = _isDiscount;

        }

        public int Count()
        {
            return _quantity;
        }

        public double Price()
        {
            return _price;
        }

        public string Name()
        {
            return _name;
        }

        public IDiscount Discount()
        {
            throw new NotImplementedException();
        }

        public string ProductId()
        {
            return _productID;
        }

        public bool IsDiscount()
        {
            return _isDiscount;
        }
    }
}
