using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Gliwice.MoWerr.StringOperations;

namespace Toci.Hornets.UnitTests.Gliwice.MoWerr.StringOperations
{
    [TestClass]
    public class MoWerrStringOperationsTest
    {
        [TestMethod]
        public void TestMoWerrStringOperationsClass()
        {
            var stringOperator = new MoWerrStringOperations();

            var operatorResults = stringOperator.RunStringOperations("witcher", "witch");
            Assert.IsTrue(operatorResults.IsStringInString);
            Assert.IsTrue(operatorResults.IsStringElementsInString);
            Assert.IsFalse(operatorResults.IsAnagram);

            operatorResults = stringOperator.RunStringOperations("witcher", "rewicht");
            Assert.IsFalse(operatorResults.IsStringInString);
            Assert.IsTrue(operatorResults.IsStringElementsInString);
            Assert.IsTrue(operatorResults.IsAnagram);

            operatorResults = stringOperator.RunStringOperations("witcher", "err");
            Assert.IsFalse(operatorResults.IsStringInString);
            Assert.IsFalse(operatorResults.IsStringElementsInString);
            Assert.IsFalse(operatorResults.IsAnagram);

            operatorResults = stringOperator.RunStringOperations("witcher", "cir");
            Assert.IsFalse(operatorResults.IsStringInString);
            Assert.IsTrue(operatorResults.IsStringElementsInString);
            Assert.IsFalse(operatorResults.IsAnagram);
        }
    }
}
