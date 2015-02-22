using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.frogie;
using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.RS.Simple;
using InitialTrainingLibrary.syf.algorythmics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.frogie
{
    [TestClass]
    public class FrogieTest
    {
        [TestMethod]
        public void TestDate()
        {
            FrogieDateValidator validator = new FrogieDateValidator();
            
            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2015, 02, 29));

            FrogieBetterDateValidator validator1 = new FrogieBetterDateValidator();

            Assert.IsFalse(validator1.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator1.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator1.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator1.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator1.DateValidate(2015, 02, 29));


            List<IDateValidator> testCollection = new List<IDateValidator>()
            {
                validator,
                validator1,
                new DateValidator()
            };

            foreach (var valid in testCollection)
            {
                Assert.IsFalse(valid.DateValidate(2014, 13, 31));
                Assert.IsFalse(valid.DateValidate(2014, 12, 32));
                Assert.IsTrue(valid.DateValidate(2014, 12, 31));
                Assert.IsFalse(valid.DateValidate(2014, 04, 31));
                Assert.IsFalse(valid.DateValidate(2015, 02, 29));
            }
        }

        [TestMethod]
        public void testPalindrom()
        {
            Assert.IsTrue(Algorythmics.IsPalindrom("radar"));
            Assert.IsTrue(Algorythmics.IsPalindrom("abnrnba"));
            Assert.IsTrue(Algorythmics.IsPalindrom("abnrrnba"));
            Assert.IsTrue(Algorythmics.IsPalindrom("123321"));
            Assert.IsFalse(Algorythmics.IsPalindrom("123jkl321"));
            Assert.IsTrue(Algorythmics.IsPalindrom2("radar"));
            Assert.IsTrue(Algorythmics.IsPalindrom2("abnrnba"));
            Assert.IsTrue(Algorythmics.IsPalindrom2("abnrrnba"));
            Assert.IsTrue(Algorythmics.IsPalindrom2("123321"));
            Assert.IsFalse(Algorythmics.IsPalindrom2("123jkl321"));
        
        }

        [TestMethod]
        public void testAnagram()
        {
            Assert.IsTrue(Algorythmics.IsAnagram("asdf0","fd0sa"));
            Assert.IsTrue(Algorythmics.IsAnagram("beata","atbae"));
            Assert.IsFalse(Algorythmics.IsAnagram("beas","atbae"));
            Assert.IsFalse(Algorythmics.IsAnagram("beaaa","atbae"));

        }

        [TestMethod]
        public void testRewers()
        {
            Assert.IsTrue(Algorythmics.Rewers("adhkl") == "lkhda");
            Assert.IsTrue(Algorythmics.Rewers("beata") == "ataeb");
            Assert.IsFalse(Algorythmics.Rewers("bartłomij") == "bartłomiej");
            
        }

        [TestMethod]
        public void testPalindrom2()
        {
            Assert.IsTrue(Algorythmics.IsPalindrom11("radar"));
            Assert.IsTrue(Algorythmics.IsPalindrom11("abnrnba"));
            Assert.IsTrue(Algorythmics.IsPalindrom11("abnrrnba"));
            Assert.IsTrue(Algorythmics.IsPalindrom11("123321"));
            Assert.IsFalse(Algorythmics.IsPalindrom11("123jkl321"));
        }
    }
}
