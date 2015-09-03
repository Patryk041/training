using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Wroclaw.AdamPast.Homework0407;

namespace Toci.Hornets.UnitTests.Wroclaw.gipson
{
    [TestClass]
    public class StringManipulationsTest
    {
        [TestMethod]
        public void StringManipulationsTestMethod()
        {
            GipsonStringManipulations gsm = new GipsonStringManipulations();
            StringManipulationsResults stm = gsm.RunStringOperations("adam", "adm");
            //Assert.IsTrue(stm.IsStringElementsInString);
            Assert.IsTrue(stm.IsStringInString);
            //Assert.IsTrue(stm.IsAnagram);
        }
    }
}