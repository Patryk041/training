using System;
using System.Collections.Generic;
using Anathema.adhed.CityTraining;
using Anathema.adhed.CityTraining.Parsers;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.adhed
{
    [TestClass]
    public class TxtCitiesParserTest
    {
        [TestMethod]
        public void ShouldParseRecordsFromTxtFile()
        {
            string path = @"..//..//adhed//CityTrainingOne//Files//cities.txt";

            TxtParser<City> parser = new TxtCitiesParser();
            List<City> list = parser.GetAllResults(path);

            Assert.IsNotNull(list);
        }
    }
}
