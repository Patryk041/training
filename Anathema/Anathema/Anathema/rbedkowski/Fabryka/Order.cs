namespace Anathema.rbedkowski.Fabryka
{
    public class Order:IOrder
    {
        public string Component { set; get; }

        public IOrder CreateComponent()
        {
            return new Order();
        } 
    }
}