using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations;

namespace Toci.BeginnersTest.TrainingOne.Recha.TextOperations
{
    [TestClass]
    public class TextOperationsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TextOperationsSets test = new TextOperationsSets(
                new string[]{ "ala", "ola", "traktor" }, 
                new string[]{ "ratat", "kran", "rata" }, 
                new string[]{ "dom", "domek", "domeczek", "do" });

            var result = test.GetPalindromsSet();
            var expectedResult = new string[] { "ala" };
            Assert.AreEqual(expectedResult[0], result[0]);

            result = test.GetAnagramsSet("tatar");
            expectedResult = new string[] { "ratat" };
            Assert.AreEqual(expectedResult[0], result[0]);

            result = test.GetWildCardSet("dom");
            expectedResult = new string[] { "dom", "domek", "domeczek" };
            for (int i = 0; i < expectedResult.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
    }
}
