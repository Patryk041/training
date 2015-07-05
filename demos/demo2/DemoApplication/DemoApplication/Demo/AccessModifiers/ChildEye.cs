using System.Runtime.Remoting.Messaging;

namespace DemoApplication.Demo.AccessModifiers
{
    public class ChildEye : Eye
    {
        public void Test()
        {
            See();

            Human hum = new Woman();

            hum.GetGender((item) => 1);


            //this.colour
        }
    }
}