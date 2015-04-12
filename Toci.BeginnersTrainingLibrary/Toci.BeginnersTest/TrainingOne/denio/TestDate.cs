using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard;
//using Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard;
using TextUtils = Toci.BeginnersTrainingLibrary.TrainingOne.Warrior.TextUtils;


namespace Toci.BeginnersTest.TrainingOne.denio
{
    [TestClass]
    public class TestDate
    {
        [TestMethod]
        public void denioDateTest()
        {
            DenioDateValidator testDate = new DenioDateValidator();
            Assert.IsTrue(testDate.CheckDate(2015, 2, 28));
            Assert.IsTrue(testDate.CheckDate(2012, 2, 29));
            Assert.IsTrue(testDate.CheckDate(1990, 12, 31));
            Assert.IsTrue(testDate.CheckDate(1987, 2, 27));
            Assert.IsFalse(testDate.CheckDate(1800, 13, 40));

        }

        [TestMethod]
        public void TestTextMethod()
        {
            //TextUtils testText = new TextUtils();
            //Assert.IsTrue(testText.);
            Assert.IsTrue(TextUtils.IsPalindrom("radar"));
            Assert.IsFalse(TextUtils.IsPalindrom("dhsafds"));
            Assert.IsTrue(TextUtils.IsPalindrom("adda"));
        }

        [TestMethod]
        public void denioTestPalindromsSet()
        {
            denioFilterSets sets = new denioFilterSets();
            var result = sets.GetPalindroms(new List<string>() { "radar", "fdsabhfda", "cyc", "fxafdagdsgsdf", "agga" });

            Assert.AreEqual(result.Length, 3);
        }

        [TestMethod]
        public void denioTestAnagram()
        {
            Anagram test = new Anagram();
            var result = test.tAnagram("Mother In Law", "The moral win");
           Assert.AreEqual(result.Length, 2);
        }
    }
}
