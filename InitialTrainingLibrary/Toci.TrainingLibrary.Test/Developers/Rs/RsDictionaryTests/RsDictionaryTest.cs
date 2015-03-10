using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.RS.RSDictionary;

namespace Toci.TrainingLibrary.Test.Developers.Rs.RsDictionaryTests
{
    [TestClass]
    public class RsDictionaryTests
    {
        [TestMethod]
        public void Is_RsDictionary_Returning_Anagrams_Correctly()
        {
            const string myAnagram = "askar";

            RsDictionary<string> targetOne = new RsDictionary<string>
            {
                {"krasa", "ValueOne"},
                {"KeyTwo", "ValueTwo"},
                {"raska", "ValueThree"}
            };

            RsDictionary<AdditionalTestClass> targetTwo = new RsDictionary<AdditionalTestClass>
            {
                {"krasa", new AdditionalTestClass{ IntValue = 1, StringValue = "ValueOne"}},
                {"KeyTwo", new AdditionalTestClass{ IntValue = 2, StringValue = "ValueTwo"}},
                {"raska", new AdditionalTestClass{ IntValue = 3, StringValue = "ValueThree"}}
            };

            var resultOne = targetOne.GetAnagramSet(myAnagram);

            Assert.IsNotNull(resultOne);
            Assert.AreEqual(2, resultOne.Count);
            Assert.AreEqual("ValueOne", resultOne[0]);
            Assert.AreEqual("ValueThree", resultOne[1]);

            var resultTwo = targetTwo.GetAnagramSet(myAnagram);

            Assert.IsNotNull(resultTwo);
            Assert.AreEqual(2, resultTwo.Count);
            Assert.AreEqual("ValueOne", resultTwo[0].StringValue);
            Assert.AreEqual("ValueThree", resultTwo[1].StringValue);
        }

        [TestMethod]
        public void Is_RsDictionary_Returning_Palindroms_Correctly()
        {
            RsDictionary<string> targetOne = new RsDictionary<string>
            {
                {"KeyOne", "ValueOne"},
                {"Boob", "ValueTwo"},
                {"KeyTwo", "ValueThree"},
                {"KeyThree", "ValueFour"},
                {"POPOP", "ValueFive"}
            };

            RsDictionary<AdditionalTestClass> targetTwo = new RsDictionary<AdditionalTestClass>
            {
                {"KeyOne", new AdditionalTestClass{ IntValue = 1, StringValue = "ValueOne"}},
                {"Boob", new AdditionalTestClass{ IntValue = 2, StringValue = "ValueTwo"}},
                {"KeyTwo", new AdditionalTestClass{ IntValue = 3, StringValue = "ValueThree"}},
                {"KeyThree", new AdditionalTestClass{ IntValue = 4, StringValue = "ValueFour"}},
                {"POPOP", new AdditionalTestClass{ IntValue = 5, StringValue = "ValueFive"}}
            };

            var resultOne = targetOne.GetPalindromSet();

            Assert.IsNotNull(resultOne);
            Assert.AreEqual(resultOne.Count, 2);
            Assert.AreEqual("ValueTwo", resultOne[0]);
            Assert.AreEqual("ValueFive", resultOne[1]);

            var resultTwo = targetTwo.GetPalindromSet();

            Assert.IsNotNull(resultTwo);
            Assert.AreEqual(resultTwo.Count, 2);
            Assert.AreEqual("ValueTwo", resultTwo[0].StringValue);
            Assert.AreEqual("ValueFive", resultTwo[1].StringValue);
        }

        [TestMethod]
        public void Is_RsDictionary_Returning_Wildcards_Correctly()
        {
            const string myWildCard = "test";

            RsDictionary<string> targetOne = new RsDictionary<string>
            {
                {"testKeyOne", "ValueOne"},
                {"KeyTwo", "ValueTwo"},
                {"testKeyThree", "ValueThree"}
            };

            RsDictionary<AdditionalTestClass> targetTwo = new RsDictionary<AdditionalTestClass>
            {
                {"testKeyOne", new AdditionalTestClass{ IntValue = 1, StringValue = "ValueOne"}},
                {"KeyTwo", new AdditionalTestClass{ IntValue = 2, StringValue = "ValueTwo"}},
                {"testKeyThree", new AdditionalTestClass{ IntValue = 3, StringValue = "ValueThree"}}
            };

            var resultOne = targetOne.GetWildcardSet(myWildCard);

            Assert.IsNotNull(resultOne);
            Assert.AreEqual(resultOne.Count, 2);
            Assert.AreEqual("ValueOne", resultOne[0]);
            Assert.AreEqual("ValueThree", resultOne[1]);

            var resultTwo = targetTwo.GetWildcardSet(myWildCard);

            Assert.IsNotNull(resultTwo);
            Assert.AreEqual(resultTwo.Count, 2);
            Assert.AreEqual("ValueOne", resultTwo[0].StringValue);
            Assert.AreEqual("ValueThree", resultTwo[1].StringValue);
        }
    }

    class AdditionalTestClass
    {
        public int IntValue { get; set; }
        public string StringValue { get; set; }
    }
}
