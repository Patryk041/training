using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils;


namespace Toci.BeginnersTest.TrainingOne.Mes.TextUtils
{
    [TestClass]
    public class Mes
    {
        [TestMethod]
        public void TestMethod()
        {
            string[] palindromCandidates = new string[] { "radar", "adda", "sadfrog", "prfesorpies"};
            string[] anagramCandidates = new string[] { "drakula", "lakurad", "kulafula" };
            string anagramPattern = "alukard";
            string[] wildcardCandidates = new string[] { "piwo", "piwopiwopiwo", "nalejpiwo" };
            string wildcardPattern = "piwo";

            var testUtils = new MesTextUtils(palindromCandidates, anagramCandidates, wildcardCandidates);

            Assert.AreEqual(2, testUtils.GetPalindromsSet().Length);
            Assert.AreEqual(2, testUtils.GetAnagramsSet(anagramPattern).Length);
            Assert.AreEqual(2, testUtils.GetWildCardSet(wildcardPattern).Length);

            string[] testarray = new string[1];
            var palindroms = new Palindroms(testarray);
            Assert.IsTrue(palindroms.CheckCandidate("radar"));
            Assert.IsFalse(palindroms.CheckCandidate("dadarar"));

            var anagrams = new Anagrams(testarray);
            anagrams.SetPattern("kebab");
            Assert.IsTrue(anagrams.CheckCandidate("babek"));
            Assert.IsFalse(anagrams.CheckCandidate("baber"));

            var wildcards = new Wildcards(testarray);
            wildcards.SetPattern("piwo");
            Assert.IsTrue(wildcards.CheckCandidate("piwokurdealepiwo"));
            Assert.IsFalse(wildcards.CheckCandidate("ziwokurdealepiwo"));


        }
    }
}
