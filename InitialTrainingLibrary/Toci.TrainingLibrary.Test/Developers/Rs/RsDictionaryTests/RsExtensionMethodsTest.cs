using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.RS.RSDictionary;

namespace Toci.TrainingLibrary.Test.Developers.Rs.RsDictionaryTests
{
    [TestClass]
    public class RsExtensionMethodsTest
    {
        [TestMethod]
        public void Is_RsExtensionMethods_Returning_Anagrams_Correctly()
        {
            const string myAnagram = "askar";

            Dictionary<string, string> target = new Dictionary<string, string>
            {
                {"krasa", "ValueOne"},
                {"KeyTwo", "ValueTwo"},
                {"raska", "ValueThree"}
            };

            var result = target.GetAnagramSet(myAnagram);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
            Assert.AreEqual("ValueOne", result[0]);
            Assert.AreEqual("ValueThree", result[1]);
        }

        [TestMethod]
        public void Is_RsExtensionMethods_Returning_Palindroms_Correctly()
        {
            Dictionary<string, string> target = new Dictionary<string, string>
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
            Assert.AreEqual("ValueTwo", result[0]);
            Assert.AreEqual("ValueFive", result[1]);
        }

        [TestMethod]
        public void Is_RsExtensionMethods_Returning_Wildcards_Correctly()
        {
            const string myWildCard = "test";

            Dictionary<string, string> target = new Dictionary<string, string>
            {
                {"testKeyOne", "ValueOne"},
                {"KeyTwo", "ValueTwo"},
                {"testKeyThree", "ValueThree"}
            };

            var result = target.GetWildcardSet(myWildCard);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
            Assert.AreEqual("ValueOne", result[0]);
            Assert.AreEqual("ValueThree", result[1]);
        }
    }
}
