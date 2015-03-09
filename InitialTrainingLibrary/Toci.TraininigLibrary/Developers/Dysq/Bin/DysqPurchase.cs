using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;
using Toci.TraininigLibrary.Developers.Dysq.Bin.Products;

namespace Toci.TraininigLibrary.Developers.Dysq.Bin
{
    public class DysqPurchase : IPurchase
    {

        private int _count;
        private double _price;
        private BootsKind _name;
        private IDiscount _discount = null;
        private bool _isDiscount;
        private string _productId;
        private double _unitPrice;

        public DysqPurchase(int count, double unitPrice, BootsKind name, bool isDiscount)
        {
            _productId = name.ToString();
            _count = count;
            _unitPrice = unitPrice;
            _price = unitPrice*count;
            _name = name;
            _isDiscount = isDiscount;

        }

        public int Count()
        {
            return _count;
        }

        public double Price()
        {
            return _price;
        }

        public string Name()
        {
            return _name.ToString();
        }

        public IDiscount Discount()
        {
            return _isDiscount ? _discount : null;
            
        }

        public string ProductId()
        {
            return _productId;
        }

        public bool IsDiscount()
        {
            return _isDiscount;
        }

        //public void SetName(BootsKind item)
        //{
        //    _name = item;
        //    _productId = item.ToString();
        //}
    }
}
