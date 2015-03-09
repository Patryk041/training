using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.RS.RSDictionary;

namespace Toci.TrainingLibrary.Test.Developers.Rs.RsDictionaryTests
{
    [TestClass]
    public class RsHashtableTest
    {
        [TestMethod]
        public void Is_RsHashtable_Returning_Anagrams_Correctly()
        {
            const string myAnagram = "askar";

            RsHashtable<string> target = new RsHashtable<string>
            {
                {"krasa", "ValueOne"},
                {"KeyTwo", "ValueTwo"},
                {"raska", "ValueThree"}
            };

            var result = target.GetAnagramSet(myAnagram);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
            Assert.IsTrue(result.Contains("ValueOne"));
            Assert.IsTrue(result.Contains("ValueThree"));
        }

        [TestMethod]
        public void Is_RsHashtable_Returning_Palindroms_Correctly()
        {
            RsHashtable<string> target = new RsHashtable<string>
            {
                {"KeyOne", "ValueOne"},
                {"Boob", "ValueTwo"},
                {"KeyTwo", "ValueThree"},
                {"KeyThree", "ValueFour"},
                {"POPOP", "ValueFive"}
            };

            var result = target.GetPalindromSet();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
            Assert.IsTrue(result.Contains("ValueTwo"));
            Assert.IsTrue(result.Contains("ValueFive"));
        }

        [TestMethod]
        public void Is_RsHashtable_Returning_Wildcards_Correctly()
        {
            const string myWildCard = "test";

            RsHashtable<string> target = new RsHashtable<string>
            {
                {"testKeyOne", "ValueOne"},
                {"KeyTwo", "ValueTwo"},
                {"testKeyThree", "ValueThree"}
            };

            var result = target.GetWildcardSet(myWildCard);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
            Assert.IsTrue(result.Contains("ValueOne"));
            Assert.IsTrue(result.Contains("ValueThree"));
        }
    }
}
