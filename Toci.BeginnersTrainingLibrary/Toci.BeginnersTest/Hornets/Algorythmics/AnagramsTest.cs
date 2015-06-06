using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            var anagramsArray = new[] {"asdasd", "michal", "imchal", "rower", "worer", "sadasdas", "rfdfadsfs"};

            var array = recognizer.ExtractAnagramArray(anagramsArray);

            Assert.AreEqual(2,array.Length);

          

        }


        [TestMethod]
        public void PolymorphAnagram()
        {
            AnagramRecognizer ASCIIRecognizer = new ASCIIAnagramRecognizer();
            AnagramRecognizer SortRecognizer = new SortAnagramRecognizer();

            AnagramsExtractor extractor = new AnagramsExtractor();

            var anagramsArray = new[] {"asdasd", "michal", "imchal", "rower", "worer", "sadasdas", "rfdfadsfs"};

            Assert.AreEqual(2,extractor.ExtractAnagrams(ASCIIRecognizer, anagramsArray));

            Assert.AreEqual(2,extractor.ExtractAnagrams(SortRecognizer, anagramsArray));
        }
    }
}