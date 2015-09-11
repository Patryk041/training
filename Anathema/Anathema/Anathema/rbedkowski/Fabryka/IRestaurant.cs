using System.Collections.Concurrent;

namespace Anathema.rbedkowski.Fabryka
{
    public interface IRestaurant
    {
        IOrder CreateOrder();      
    }
}