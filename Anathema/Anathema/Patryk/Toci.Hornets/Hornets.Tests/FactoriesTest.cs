using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Cars;
using Toci.Hornets.Cars.Abstract;
using Toci.Hornets.Factories;

namespace Hornets.Tests
{
    [TestClass]
    public class FactoriesTest
    {
        [TestMethod]
        public void CarFactoryTest()
        {
            CarFactory carFactory = new CarFactory();

            ICar honda = carFactory.GetCar("Honda");

            honda.Color = Color.Blue;

            ICar anotherHonda = carFactory.GetCar("Honda");



        }
    }
}
