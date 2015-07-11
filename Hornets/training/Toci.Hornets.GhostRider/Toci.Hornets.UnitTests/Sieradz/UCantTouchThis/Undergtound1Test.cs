using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{  
    [TestClass]
    public class Undergtound1Test
    {
       private readonly List<string[]> _stringsToTest = new List<string[]>
        {
            new []{"lol", "yol123"},
            new []{"123", "22222"},
            new []{"DadD", "^*asd^&^^7&^Q3123"},
            new []{"DadD", "^*asd^&^^7&^Q3123"},
            new []{"DadDz", "DadDZ"}
        };

        private readonly List<IStringComparator> Comparators = new List<IStringComparator>
        {
            new UCantTouchThisStringComparator(),
            new UCTT_AutismStringComparator()
        };
            
        [TestMethod]
        public void UCTTStringsComparatorTest()
        {
            foreach (var stringComparator in Comparators)
            {
                TestSingleComparator(stringComparator);   
            }

        }

        private void TestSingleComparator(IStringComparator comparator)
        {
            _stringsToTest.ForEach(item => Assert.IsTrue(comparator.CompareTwoStrings(item[0], item[1])));
            
        }
         
    }
}