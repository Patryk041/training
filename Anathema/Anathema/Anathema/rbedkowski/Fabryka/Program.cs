namespace Anathema.rbedkowski.Fabryka
{
    public class Program
    {
        public void test()
        {
            Restaurant restaurant = new Restaurant();
            var order = restaurant.CreateOrder();
            restaurant.NrOrder = 1;
            
        }


    }
}