using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Bytom.gipson.Homework0407;

namespace Toci.Hornets.UnitTests.Bytom.gipson
{
    [TestClass]
    public class StringManipulationsTest
    {
        [TestMethod]
        public void StringManipulationsTestMethod()
        {
            GipsonStringManipulations gsm = new GipsonStringManipulations();
            StringManipulationsResults stm = gsm.RunStringOperations("adam", "adma");
            Assert.IsTrue(stm.IsStringElementsInString);
            Assert.IsFalse(stm.IsStringInString);
            Assert.IsTrue(stm.IsAnagram);
        }
    }
}