using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Wroclaw.Tszulczewski.Training2HomeWork;

namespace Toci.Hornets.UnitTests.Wroclaw.Tszulczewski
{
    [TestClass]
    public class StringManipulationsTest
    {
        [TestMethod]
        public void StringManipulationsTestMethod()
        {
            TszulczewskiStringManipulations obj1 = new TszulczewskiStringManipulations();
            StringManipulationsResults stringmresults = obj1.RunStringOperations("Alunia", "Alunia");
            Assert.IsFalse(stringmresults.IsStringInString);
            Assert.IsFalse(stringmresults.IsStringElementsInString);
            Assert.IsTrue(stringmresults.IsAnagram);
        }
         
    }
}