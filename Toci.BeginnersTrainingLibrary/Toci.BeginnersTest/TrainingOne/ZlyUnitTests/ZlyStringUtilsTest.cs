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
          
            Assert.IsTrue(ZlyTextUtils.IsPalindrom("radar"));
        }


        [TestMethod]
        public void TestTextUtilsAnagram()
        {
           
            ZlyFilterSets sets = new ZlyFilterSets();
            var result = sets.GetAnagrams((new[] {"test", "set", "sratata", "knowalia", "ailawonk"}), "konwalia");
            Assert.AreEqual(result.Length, 2);
        }


        [TestMethod]
        public void TestPalindromsSet()
        {
            ZlyFilterSets sets = new ZlyFilterSets();
            var result = sets.GetPalindroms(new[] {"radar", "fdsadsfsdf", "cyc"});


           
        }
    }
}
