using System;
using System.Collections.Generic;
using System.Diagnostics;
using InitialTrainingLibrary.dysq.DateValidator;
using InitialTrainingLibrary.frogie;
using InitialTrainingLibrary.frogie.FrogieComplexDateValidator;
using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.robson;
using InitialTrainingLibrary.syf.algorythmics;
using InitialUnitTest.frogie.EfficiencyMonitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.frogie
{
    [TestClass]
    public class FrogieTest
    {
        [TestMethod]
        public void FrogieTestDate()
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
                new FrogieYetBetterDateValidator(),

                new InitialTrainingLibrary.RS.Simple.DateValidator(),
                new InitialTrainingLibrary.RS.Complex.DateValidator(),
                new MyDate(),
                new InitialTrainingLibrary.Sito._1.DateValidator(),
                new InitialTrainingLibrary.koziu.DateValidator.DateValidator(),
                new InitialTrainingLibrary.mg.DateValidator.DateValidator(),
                new InitialTrainingLibrary.szymon93._1__DateValidator.DateValidator(),
                new Date(),
                new InitialTrainingLibrary.hipek._1.DateValidator.DateValidator()
            };

            List<EfficiencyMonitorEntity> efficiencyResults = new List<EfficiencyMonitorEntity>(testCollection.Count);

            foreach (var valid in testCollection)
            {
                var efficiencyResult = new EfficiencyMonitorEntity() {Author = valid.GetName()};

                var start = DateTime.Now.Millisecond;

                //for (int i = 0; i < 10000; i++)
                {
                    efficiencyResult.FailsCount += valid.DateValidate(2014, 13, 31) ? 1 : 0;
                    efficiencyResult.FailsCount += valid.DateValidate(2014, 12, 32) ? 1 : 0;
                    efficiencyResult.FailsCount += valid.DateValidate(2014, 12, 31) ? 0 : 1;
                    efficiencyResult.FailsCount += valid.DateValidate(2014, 04, 31) ? 1 : 0;
                    efficiencyResult.FailsCount += valid.DateValidate(2015, 02, 29) ? 1 : 0;
                    efficiencyResult.FailsCount += valid.DateValidate(2015, 02, 28) ? 0 : 1;
                    efficiencyResult.FailsCount += valid.DateValidate(2016, 02, 29) ? 0 : 1;
                    efficiencyResult.FailsCount += valid.DateValidate(2016, 02, 30) ? 1 : 0;
                }

                var end = DateTime.Now.Millisecond;

                efficiencyResult.Time = end - start;

                efficiencyResults.Add(efficiencyResult);
            }

            efficiencyResults.Sort((r, r2) => testComparison(r.Time, r2.Time));

            foreach (var result in efficiencyResults)
            {
                Debug.WriteLine("name: {0}, time: {1}, fails: {2}", result.Author, result.Time, result.FailsCount);
            }
        }

        private int testComparison(double x, double y)
        {
            return x > y ? 1 : x < y ? -1 : 0;
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

        [TestMethod]
        public void testTekst()
        {
       //     Assert.IsTrue(Palindrom.tekst("beata", "ata"));
         //   Assert.IsTrue(Palindrom.tekst("bartekartak", "artak"));
           // Assert.IsFalse(Palindrom.tekst("bartefghju", "rtefbvf"));

            //StringReplace.WytnijTekst("Beata", "at");
            //StringReplace.WytnijTekst("Beata", "ata");
            //StringReplace.WytnijTekst("Beata", "ea");
            //StringReplace.WytnijTekst("Beata", "eat");
            Assert.AreEqual(StringReplace.WytnijTekst("Beata", "eat"), "Ba");
            Assert.AreEqual(StringReplace.WytnijTekst("Beata", "ata"), "Be");
            Assert.AreEqual(StringReplace.WytnijTekst("Beata", "ea"), "Bta");
            //Assert.IsTrue(StringReplace.CzyTeksWystepuje("Beata","ata"));
            //Assert.IsTrue(StringReplace.CzyTeksWystepuje("Beata","eat"));
            //Assert.IsFalse(StringReplace.CzyTeksWystepuje("Beata","poi"));
            //Assert.IsFalse(StringReplace.CzyTeksWystepuje("Beata","eaa"));
            //Assert.IsTrue(StringReplace.CzyTeksWystepuje("Beata","at"));
        }
    }
}
