using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{  
    [TestClass]
    public class Undergtound1Test
    {

        [TestMethod]
        public void UCantTouchThisStringComparatorTest()
        {
            var comp = new UCantTouchThisStringComparator();
            List<string[]> stringsToTest = new List<string[]>
            {
                new []{"lol", "yol123"},
                new []{"123", "22222"},
                new []{"DadD", "^*asd^&^^7&^Q3123"},
                new []{"DadD", "^*asd^&^^7&^Q3123"},
                new []{"DadD", "DadD"}
            };
            
            //List<bool> restultLis = stringsToTest.Select(item => comp.CompareTwoStrings(item[0], item[1])).ToList();

//            foreach (var item in stringsToTest)
//            {
//                Assert.IsTrue(comp.CompareTwoStrings(item[0],item[1]));
//            }

            stringsToTest.ForEach(item => Assert.IsTrue(comp.CompareTwoStrings(item[0], item[1])));
        }
         
    }
}