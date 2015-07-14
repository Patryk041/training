using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.RandomStringGenerator;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class RandomStringGeneratorTests
    {
        private const int NumberOfRandomStringPairs = 10000;
        private const int LengthOfRandomString = 32;
        private const int MaxRandomStringLength = 1000;

        private readonly List<string[]> _testList = UCTT_RandomStingGenerator.GenerateRandomStringPaitList(NumberOfRandomStringPairs, LengthOfRandomString);

        [TestMethod]
        public void UCTT_RandomStringGeneratorTest()
        {
            for (int i = 0; i < MaxRandomStringLength; i++)
                Assert.AreEqual(UCTT_RandomStingGenerator.GenerateRandomString(i).Length, i);
        }

        [TestMethod]
        public void UCTT_RandomStringPairListTest()
        {
            Assert.IsNotNull(_testList);
            _testList.ForEach(Assert.IsNotNull);
        }



    }
}