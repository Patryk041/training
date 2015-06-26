using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Toci.BeginnersTrainingLibrary.Hornets.AccessModifiers;
using Toci.BeginnersTrainingLibrary.Hornets.Algorythmics;
using Toci.BeginnersTrainingLibrary.Hornets.Strategy;

namespace Toci.BeginnersTest.Hornets.Algorythmics
{
    [TestClass]
    public class AnagramsTest
    {
        [TestMethod]
        public void TestAnagrams()
        {
            var anagramrecognizer = new SillyAnagramRecognizer();

            Assert.IsFalse(anagramrecognizer.IsAnagram("dfsfdasgfdgfads", "fdsafadfbhadsf"));
            Assert.IsTrue(anagramrecognizer.IsAnagram("michal", "imchal"));


        }

        [TestMethod]
        public void TestFaultyAnagrams()
        {

            var recoginzer = new SillyAnagramRecognizer();

            Assert.IsFalse(recoginzer.FaultyIsAnagram("asdasdasd","sadasdasdas"));
            Assert.IsTrue(recoginzer.FaultyIsAnagram("michal","imchal"));

            Assert.IsFalse(recoginzer.FaultyIsAnagram("ad","bc"));
            // a = 97, d = 100
            // b = 98 , c = 99

        }


        [TestMethod]
        public void TestExtractAnagram()
        {

            var recognizer = new SillyAnagramRecognizer();

            var anagramsArray = new[] {"asdasd", "michal", "imchal", "rower", "worer", "sadasdas", "rfdfadsfs","lmicha"};

            Dictionary<int, List<string>> anagramsDictonary = recognizer.ExtractAnagramsDictionary(new List<string>(anagramsArray));

            Assert.AreEqual(2, anagramsDictonary.Count);
            Assert.AreEqual(3,anagramsDictonary[0].Count);
            Assert.AreEqual(2, anagramsDictonary[1].Count);

          

        }


        [TestMethod]
        public void PolymorphAnagram()
        {
            AnagramRecognizer ASCIIRecognizer = new ASCIIAnagramRecognizer();
            AnagramRecognizer SortRecognizer = new SortAnagramRecognizer();

            AnagramsExtractor extractor = new AnagramsExtractor(SortRecognizer);

            var anagramsArray = new[] { "asdasd", "michal", "imchal", "rower", "worer", "sadasdas", "rfdfadsfs", "lmicha" };

            Dictionary<int, List<string>> anagramsDictonary = extractor.ExtractAnagramsDictionary(new List<string>(anagramsArray));

            Assert.AreEqual(2, anagramsDictonary.Count);
            Assert.AreEqual(3, anagramsDictonary[0].Count);
            Assert.AreEqual(2, anagramsDictonary[1].Count);

            anagramsArray = new[] { "ad","bc" };
            //setter
            extractor.AnagramRecognizer = ASCIIRecognizer;

            anagramsDictonary = extractor.ExtractAnagramsDictionary(new List<string>(anagramsArray));

            //Assert.AreEqual(0, anagramsDictonary.Count);
        }
    }
}