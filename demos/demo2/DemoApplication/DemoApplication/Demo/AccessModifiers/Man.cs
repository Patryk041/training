using System;

namespace DemoApplication.Demo.AccessModifiers
{
    public class Man : Human
    {
        protected override int Recognize(Func<Human, int> recDelegate)
        {
            throw new System.NotImplementedException();
        }
    }
}