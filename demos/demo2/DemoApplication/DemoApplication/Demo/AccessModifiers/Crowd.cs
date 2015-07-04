namespace DemoApplication.Demo.AccessModifiers
{
    public class Crowd
    {
        public void CrowdInTheMarket()
        {
            Human polak = new Human();
            Human yagha = new Human();

            ChildEye eye = new ChildEye();

            //eye.colour

            polak.See(yagha);
        }
    }
}