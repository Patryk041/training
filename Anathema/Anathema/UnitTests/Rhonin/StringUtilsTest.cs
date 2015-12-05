using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.Rhonin.Words;

namespace UnitTests.Rhonin
{
    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void TestTextutilsPalindroms()
        {
            Assert.IsFalse(TextUtils.IsPalindrom("fadg"));
            Assert.IsTrue(TextUtils.IsPalindrom("radar"));
            
        }

        [TestMethod]
        public void TestPalindromsSets()
        {
            FilterSets sets = new FilterSets();
            var result = sets.GetPalindroms(new[] { "radar", "kajak", "test" });
            Assert.AreEqual(result.Length, 2);
        }

        [TestMethod]
        public void TestAnagramsSets()
        {
            FilterSets sets = new FilterSets();
            sets.words = new[] {"radar", "kajak", "test"};
            string[] result = sets.GetAnagramsSet("kaajk");
            Assert.AreEqual(result.Length, 1);
        }

        [TestMethod]
        public void TestTextutilsAnagrams()
        {
            Assert.IsFalse(TextUtils.IsAnagram("fadg","loll"));
            Assert.IsTrue(TextUtils.IsAnagram("radar","rrada"));

        }

        [TestMethod]
        public void TestTextutilsWildCard()
        {
            Assert.IsFalse(TextUtils.IsWildCard("fadg", "loll"));
            Assert.IsTrue(TextUtils.IsWildCard("radar", "r"));

        }

        [TestMethod]
        public void TestWildCardsSets()
        {
            FilterSets sets = new FilterSets();
            sets.words = new[] { "radar", "kajak", "test" };
            var result = sets.GetWildCards("ra");
            Assert.AreEqual(result.Length, 1);
        }
    }
}
