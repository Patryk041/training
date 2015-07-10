using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.SemiRafista.TrainingTwoStringManipulations;

namespace Toci.Hornets.UnitTests.Rzeszow.SemiRafista
{
    [TestClass]
    public class SeRaManipulatingStringsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var seRaTest = new SeRaManipulatingStrings();

            //IsStringInString
            Assert.IsTrue(seRaTest.RunStringOperations("beata","eat").IsStringInString);
            Assert.IsFalse(seRaTest.RunStringOperations("beata", "et").IsStringInString);

            //IsStringElementsInString
            Assert.IsTrue(seRaTest.RunStringOperations("beata", "taa").IsStringElementsInString);
            Assert.IsFalse(seRaTest.RunStringOperations("beata", "ataa").IsStringElementsInString);

            //IsStringAnagram
            Assert.IsTrue(seRaTest.RunStringOperations("beata", "eatba").IsAnagram);
            Assert.IsFalse(seRaTest.RunStringOperations("beata", "ttbae").IsAnagram);
        }
    }
}
