using System;
using System.Collections.Generic;
using Anathema.adhed.CityTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.adhed
{
    [TestClass]
    public class CityListTest
    {

        [TestMethod]
        public void ShouldReturnEmptyList()
        {
            CityList cityList = new CityList();
            List<City> list = cityList.GetList();

            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void ShouldReturnListWithCities()
        {
            CityList cityList = new CityList();

            City city1 = new City("Przesieka");
            City city2 = new City("Karpacz");
            City city3 = new City("Jelenia Gora");

            cityList.AddElement(city1);
            cityList.AddElement(city2);
            cityList.AddElement(city3);

            List<City> list = cityList.GetList();

            Assert.AreEqual(list.Count, 3);

        }

        [TestMethod]
        public void ShouldReturnTrueWhenLookingForCity()
        {
            CityList cityList = new CityList();
            City city = new City("Karpacz");
            cityList.AddElement(city);

            Assert.IsTrue(cityList.CityExistsInList("Karpacz"));
        }

        [TestMethod]
        public void ShouldReturnFalseWhenLookingForCity()
        {
            CityList cityList = new CityList();
            City city = new City("Przesieka");
            cityList.AddElement(city);

            Assert.IsFalse(cityList.CityExistsInList("Karpacz"));
        }
    }
}
