using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.wojtek.factory;

namespace UnitTests.wojtek
{
    [TestClass]
    public class BikeFactoryTest
    {
        [TestMethod]
        public void BikeFactoryMethodtest()
        {
            var bikeFactoryInstance = new BikeFactory();
            var bike = bikeFactoryInstance.Create("Specialized");
            bike.Colour = "Green";
            var test= bike.Ride("Enduro");
        }
    }
}
