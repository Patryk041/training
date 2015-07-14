using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.StringManipulation;

namespace Toci.Hornets.UnitTests.Gliwice.Hipek.TaskTrainingTwoTest
{
    [TestClass]
    public class HipekStringManipulationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string subject = "beata";
            string seek = "ata";
            HipekStringManipulation stringManipulation = new HipekStringManipulation();

            var result = stringManipulation.RunStringOperations(subject, seek);

            Assert.IsTrue(result.IsStringInString);
            Assert.IsTrue(result.IsStringElementsInString);
            Assert.IsFalse(result.IsAnagram);

            subject = "beata";
            seek = "aat";
            result = stringManipulation.RunStringOperations(subject, seek);

            Assert.IsFalse(result.IsStringInString);
            Assert.IsTrue(result.IsStringElementsInString);
            Assert.IsFalse(result.IsAnagram);

            subject = "beata";
            seek = "tbaea";
            result = stringManipulation.RunStringOperations(subject, seek);

            Assert.IsFalse(result.IsStringInString);
            Assert.IsTrue(result.IsStringElementsInString);
            Assert.IsTrue(result.IsAnagram);

            subject = "beata";
            seek = "beata";
            result = stringManipulation.RunStringOperations(subject, seek);

            Assert.IsTrue(result.IsStringInString);
            Assert.IsTrue(result.IsStringElementsInString);
            Assert.IsTrue(result.IsAnagram);

            subject = null;
            seek = null;
            result = stringManipulation.RunStringOperations(subject, seek);

            Assert.IsFalse(result.IsStringInString);
            Assert.IsFalse(result.IsStringElementsInString);
            Assert.IsFalse(result.IsAnagram);
        }
    }
}
