using System;
using System.Collections.Generic;
using Anathema.adhed.CityTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.adhed
{
    [TestClass]
    public class CityManagerTest
    {
        [TestMethod]
        public void ShouldReturnEmptyList()
        {
            CityManager manager = new CityManager();
            List<City> list = manager.GetCities();

            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void ShouldReturnListWithCities()
        {
            CityManager manager = new CityManager();

            City city1 = new City("Przesieka");
            City city2 = new City("Karpacz");
            City city3 = new City("Jelenia Gora");

            manager.AddCityToList(city1);
            manager.AddCityToList(city2);
            manager.AddCityToList(city3);

            List<City> list = manager.GetCities();

            Assert.AreEqual(list.Count, 3);
            
        }
    }
}
