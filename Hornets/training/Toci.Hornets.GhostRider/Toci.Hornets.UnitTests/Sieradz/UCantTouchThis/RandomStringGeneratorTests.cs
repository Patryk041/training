using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.RandomStringGenerator;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class RandomStringGeneratorTests
    {
        [TestMethod]
        public void RSGTestMethod()
        {
            for (int i = 0; i < 1000; i++)
            {
                Assert.IsNotNull(UCTT_RandomStingGenerator.GenerateRandomString(i));
            }

        }

        [TestMethod]
        public void RandomStringPairListTest()
        {
            List<string[]> testList = UCTT_RandomStingGenerator.GenerateRandomStringPaitList(100000, 20);

            Assert.IsNotNull(testList);

            testList.ForEach(Assert.IsNotNull);

        }



    }
}