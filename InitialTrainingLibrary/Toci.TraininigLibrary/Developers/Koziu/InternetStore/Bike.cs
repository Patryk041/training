using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.InternetStore;

namespace Toci.TraininigLibrary.Developers.Koziu.InternetStore
{
    public class Bike  : IPurchase
    {
        //primary properties
        private readonly int _price ;
        private readonly int _count;
        private readonly string _name;
        private readonly string _productId;
        private readonly bool _isDiscount;
        private readonly KoziuDiscount _discount;
        private readonly bool _isNew;
        private readonly BikeKind _kind;

        //optional properties
        private readonly int _frameSize;
        private readonly int _wheelSize;
        private readonly double _weight;



        public Bike(int price, int count, string name, string productId, KoziuDiscount discount, bool isDiscount, bool isNew, BikeKind kind)
        {
            _price = price;
            _count = count;
            _name = name;
            _productId = productId;
            _discount = discount;
            _isDiscount = isDiscount;
            _isNew = isNew;
            _kind = kind;
        }
        public Bike(int price, int count, string name, string productId, KoziuDiscount discount, bool isDiscount, bool isNew, BikeKind kind, int frameSize, int wheelSize, double weight) 
        {
            _price = price;
            _count = count;
            _name = name;
            _productId = productId;
            _discount = discount;
            _isDiscount = isDiscount;
            _isNew = isNew;
            _kind = kind;
            _frameSize = frameSize;
            _wheelSize = wheelSize;
            _weight = weight;
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
            return _name;
        }    
        public IDiscount Discount()
        {
            return _discount;
        }   
        public string ProductId()
        {
            return _productId;
        }     
        public bool IsDiscount()
        {
            return _isDiscount;
        }    
        public bool IsNew()
        {
            return _isNew;
        }     
        public BikeKind Kind()
        {
            return _kind;
        }

        public int FrameSize()
        {
            return _frameSize;
        }      
        public int WheelSize()
        {
            return _wheelSize;
        }          
        public double Weight()
        {
            return _weight;
        }
    }
}
