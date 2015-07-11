using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW;

namespace Toci.Hornets.UnitTests.Kalisz.Adrianowsky94
{
    [TestClass]
    public class PeselTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            var validPesels = new List<string>
            {
                "95121715083",
                "57031312507",
                "41030516093",
                "66042212311",
                "81061912033",
                "64101306575",
                "29071211739",
                "38012100481",
                "61111009591",
                "71022507224",
                "42511506495",
                "33483008225",
                "28491619596",
                "58912209819",
                "44682908368",
                "56680804126"
            };

            var invalidPesels = new List<string> //just random numbers, let's hope it's not actual PESEL
            {
                "123489611468",
                "1f6ds1f64f4",
                "123132456",
                "6786d78s9",
                "8908908989",
                "0000000000",
                "dsadwdwff11",
                "bfyhjbfhyjdf",
                "25616148013",
                "44885566331",
                "1",
                "71022507223"
            };
            var validator = new A94PeselValidator();
            foreach (var psl in validPesels)
            {
                Assert.IsTrue(validator.IsPeselValid(psl));
            }
            foreach (var psl in invalidPesels)
            {
                Assert.IsFalse(validator.IsPeselValid(psl));
            }
        }
    }
}
