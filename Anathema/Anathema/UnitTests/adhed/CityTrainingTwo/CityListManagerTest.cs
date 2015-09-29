using System;
using System.Collections.Generic;
using Anathema.adhed.CityTrainingTwo;
using Anathema.adhed.CityTrainingTwo.Generics;
using Anathema.adhed.Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.adhed.CityTrainingTwo
{
    [TestClass]
    public class CityListManagerTest
    {
        [TestMethod]
        public void ShouldGetEmptyList()
        {
            GenericListManager<City> listManager = new CityListManager();
            List<City> list = listManager.GetList();

            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void ShouldGetListWithTwoRecords()
        {
            GenericListManager<City> listManager = new CityListManager();
           
            City city1 = new City("Karpacz");
            City city2 = new City("Jelenia Góra");

            listManager.AddElement(city1);
            listManager.AddElement(city2);

            List<City> list = listManager.GetList();

            Assert.AreEqual(list.Count, 2);
        }

        [TestMethod]
        public void ShouldCityNotExists()
        {
            GenericListManager<City> listManager = new CityListManager();
            bool result = listManager.CheckElementExists("Karpacz");

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void ShouldCityExists()
        {
            GenericListManager<City> listManager = new CityListManager();
            City city = new City("Karpacz");

            listManager.AddElement(city);

            bool result = listManager.CheckElementExists("Karpacz");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldJoinTheList()
        {
            GenericListManager<City> listManager = new CityListManager();

            City city1 = new City("Karpacz");
            City city2 = new City("Waszyngton");
            City city3 = new City("Świebodzin");

            listManager.AddElement(city1);

            List<City> anotherList = new List<City>();
            anotherList.Add(city2);
            anotherList.Add(city3);

            listManager.JoinList(anotherList);

            //check that city from another list exists in main list after the join process
            bool result = listManager.CheckElementExists("Waszyngton");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldLoadTheCitiesFromTxtFile()
        {
            GenericListManager<City> listManager = new CityListManager();

            string path = @"..//..//adhed//CityTrainingTwo//Files//cities.txt";
            listManager.LoadElements(path);

            List<City> list = listManager.GetList();

            bool result = listManager.CheckElementExists("Pieszyce");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldGetCitiesStartsWithSpecifiedLetter()
        {
            CityListManager listManager = new CityListManager();

            string path = @"..//..//adhed//CityTrainingTwo//Files//cities.txt";
            listManager.LoadElements(path);
           
            List<City> listWithZ = listManager.GetCitiesStartsWithLetter("Z");

            Assert.AreEqual(listWithZ.Count, 2);
        }

        [TestMethod]
        public void ShouldRemoveCityFromList()
        {
            CityListManager listManager = new CityListManager();

            string path = @"..//..//adhed//CityTrainingTwo//Files//cities.txt";
            listManager.LoadElements(path);

            var result1 = listManager.CheckElementExists("Karpacz");

            listManager.RemoveElement("Karpacz");

            var result2 = listManager.CheckElementExists("Karpacz");

            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void ShouldCountCitiesStartsWithLetter()
        {
            CityListManager listManager = new CityListManager();

            var city1 = new City("Karpacz");
            var city2 = new City("Wieleń");
            var city3 = new City("Warszawa");

            listManager.AddElement(city1);
            listManager.AddElement(city2);
            listManager.AddElement(city3);

            var result = listManager.CountElementsStartWithLetter("W");

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void ShouldCountCities()
        {
            CityListManager listManager = new CityListManager();

            var city1 = new City("Karpacz");
            var city2 = new City("Wieleń");

            listManager.AddElement(city1);
            listManager.AddElement(city2);

            var result = listManager.CountElements();

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void ShouldRemoveDuplicates()
        {
            CityListManager listManager = new CityListManager();

            var city1 = new City("Karpacz");
            var city2 = new City("Wieleń");
            var city3 = new City("Warszawa");
            var city4 = new City("Karpacz");
            var city5 = new City("Wieleń");

            listManager.AddElement(city1);
            listManager.AddElement(city2);
            listManager.AddElement(city3);
            listManager.AddElement(city4);
            listManager.AddElement(city5);

            var result1 = listManager.CountElements();

            listManager.RemoveDuplicates(new CitiesComparer());

            var result2 = listManager.CountElements();

            Assert.AreEqual(result2, 3);


        }


    }
}
