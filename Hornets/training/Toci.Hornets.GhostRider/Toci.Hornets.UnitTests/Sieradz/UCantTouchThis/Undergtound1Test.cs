using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{  
    [TestClass]
    public class Undergtound1Test
    {

        [TestMethod]
        public void UCantTouchThisStringComparatorTest()
        {
            //var comp = new UCantTouchThisStringComparator();
            var comp = new UCTT_AutismStringComparator();
            List<string[]> stringsToTest = new List<string[]>
            {
                new []{"lol", "yol123"},
                new []{"123", "22222"},
                new []{"DadD", "^*asd^&^^7&^Q3123"},
                new []{"DadD", "^*asd^&^^7&^Q3123"},
                new []{"DadDz", "DadDZ"}
            };

            stringsToTest.ForEach(item => Assert.IsTrue(comp.CompareTwoStrings(item[0], item[1])));
        }
         
    }
}