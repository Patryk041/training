using System.Runtime.Remoting.Messaging;

namespace Anathema.rbedkowski.Fabryka
{
    public class Restaurant:IRestaurant
    {
        public int NrOrder { set; get; }

        public IOrder CreateOrder()
        {
            return new Order();
        }

    }
}