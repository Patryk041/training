using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.Text;

namespace Toci.BeginnersTest.TrainingOne.S2yfr4nt.TextOperationsTest
{
    [TestClass]
    public class TextUtilsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            S2yfr4ntTextOpertionsSets test = new S2yfr4ntTextOpertionsSets(
               new string[] { "ala", "kolok", "test" },
               new string[] { "womanhitler", "starafs", "rdsfds" },
               new string[] { "test", "tested", "tes", "atest" });

            var result = test.GetPalindromsSet();
            var expectedResult = new string[] { "ala", "kolok" };
            Assert.AreEqual(expectedResult[0], result[0]);
            Assert.AreEqual(expectedResult[1], result[1]);

            result = test.GetAnagramsSet("motherinlaw");
            expectedResult = new string[] { "womanhitler" };
            Assert.AreEqual(expectedResult[0], result[0]);

            result = test.GetWildCardSet("test");
            expectedResult = new string[] { "test", "tested" };
            for (int i = 0; i < expectedResult.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
    }
}
