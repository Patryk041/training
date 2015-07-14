using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.AdamP.TaskTrainingTwo;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using PeselValidator = Toci.Hornets.Bytom.AdamP.TaskTrainingTwo.PeselValidator;

namespace Toci.Hornets.UnitTests.Bytom.AdamP
{
    [TestClass]
    public class AdamPFirstUnitTest
    {
        [TestMethod]
        public void TestPeselValidator()
        {
            PeselValidator checkPeselValidator = new PeselValidator();
            Assert.IsTrue(checkPeselValidator.IsPeselValid("86012900792"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid("99999999999"));
        }
        [TestMethod]
        public void TestStringManipulation()
        {
            
        }

    }

}
