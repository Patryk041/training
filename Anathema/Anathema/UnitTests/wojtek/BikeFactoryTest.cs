using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.wojtek.factory;
using Anathema.wojtek.factory.Bikes;

namespace UnitTests.wojtek
{
    [TestClass]
    public class BikeFactoryTest
    {
        [TestMethod]
        public void BikeFactoryMethodtest()
        {
            BikeFactory BikeFactoryInstance = new BikeFactory();
            IBike Bike = BikeFactoryInstance.Create("Specialized");
            Bike.Colour = "Green";
            var test= Bike.Ride("Enduro");
        }
    }
}
