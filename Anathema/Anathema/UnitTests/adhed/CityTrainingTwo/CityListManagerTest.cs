using System;
using System.Collections.Generic;
using Anathema.adhed.CityTrainingTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.adhed.CityTrainingTwo
{
    [TestClass]
    public class CityListManagerTest
    {
        [TestMethod]
        public void ShouldGetEmptyList()
        {
            CityListManager listManager = new CityListManager();
            List<City> list = listManager.GetCitiesList();

            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void ShouldGetListWithTwoRecords()
        {
            CityListManager listManager = new CityListManager();
           
            City city1 = new City("Karpacz");
            City city2 = new City("Jelenia Góra");

            listManager.AddCity(city1);
            listManager.AddCity(city2);

            List<City> list = listManager.GetCitiesList();

            Assert.AreEqual(list.Count, 2);
        }

        [TestMethod]
        public void ShouldCityNotExists()
        {
            CityListManager listManager = new CityListManager();
            bool result = listManager.CheckCityExists("Karpacz");

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void ShouldCityExists()
        {
            CityListManager listManager = new CityListManager();
            City city = new City("Karpacz");

            listManager.AddCity(city);

            bool result = listManager.CheckCityExists("Karpacz");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldJoinTheList()
        {
            CityListManager listManager = new CityListManager();

            City city1 = new City("Karpacz");
            City city2 = new City("Waszyngton");
            City city3 = new City("Świebodzin");

            listManager.AddCity(city1);

            List<City> anotherList = new List<City>();
            anotherList.Add(city2);
            anotherList.Add(city3);

            listManager.JoinList(anotherList);

            //check that city from another list exist in main list after the join process
            bool result = listManager.CheckCityExists("Waszyngton");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldLoadTheCitiesFromTxtFile()
        {
            CityListManager listManager = new CityListManager();

            string path = @"..//..//adhed//CityTrainingTwo//Files//cities.txt";
            listManager.LoadCities(path);

            List<City> list = listManager.GetCitiesList();

            Assert.IsNotNull(list);
        }


    }
}
