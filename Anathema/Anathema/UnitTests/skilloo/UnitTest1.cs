using System;
using System.CodeDom;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.Skilloo.Fabryka;

namespace UnitTests.skilloo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FabrykaTestMethod()
        {
            CarFactory fact = new CarFactory();

            var car = fact.GetCar("Golf");

            car.color = Color.Red;
            var car2 = fact.GetCar("Golf");
            if(car2 ==typeof( Passat))
                ((Passat)car2).GetSomething();
           
        }
    }
}
