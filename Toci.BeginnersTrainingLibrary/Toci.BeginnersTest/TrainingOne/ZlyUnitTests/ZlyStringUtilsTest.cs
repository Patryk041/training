using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Warrior;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zly.TextOpeartionsSet;

namespace Toci.BeginnersTest.TrainingOne.ZlyUnitTests
{
    [TestClass]
    public class ZlyStringUtilsTest
    {
        [TestMethod]
        public void TestTextUtilPalindrom()
        {
           
        }


        [TestMethod]
        public void TestPalindromsSet()
        {
            ZlyFilterSets sets = new ZlyFilterSets();
            var result = sets.GetPalindroms(new[] {"radar", "fdsadsfsdf", "cyc"});


           
        }
    }
}
