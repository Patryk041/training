using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.AdamP.TaskTrainingTwo;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using PeselValidator = Toci.Hornets.Bytom.AdamP.TaskTrainingTwo.AdamPPeselValidator;

namespace Toci.Hornets.UnitTests.Bytom.AdamP
{
    [TestClass]
    public class AdamPPeselValidatorTest
    {
        [TestMethod]
        public void TestPeselValidator()
        {
            var checkPeselValidator = new AdamPPeselValidator();
            Assert.IsTrue(checkPeselValidator.IsPeselValid("86012900792"));
            Assert.IsTrue(checkPeselValidator.IsPeselValid("92041514956"));
            Assert.IsTrue(checkPeselValidator.IsPeselValid("66012900794"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid("99999999999"));
        }
    }

}
