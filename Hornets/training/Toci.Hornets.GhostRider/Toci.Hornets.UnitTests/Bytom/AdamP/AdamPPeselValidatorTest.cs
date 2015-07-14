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
        public void APTestPeselValidatorWithProperLength()
        {
            var checkPeselValidator = new AdamPPeselValidator();
            Assert.IsTrue(checkPeselValidator.IsPeselValid("92041514956"));
            Assert.IsTrue(checkPeselValidator.IsPeselValid("66012900794"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid("99999999999"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid("66012900795"));
        }

        [TestMethod]
        public void APTestPeselValidatorWithWeirdString()
        {
            var checkPeselValidator = new AdamPPeselValidator();
            Assert.IsFalse(checkPeselValidator.IsPeselValid("abc"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid("47"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid("qwerty"));
            Assert.IsFalse(checkPeselValidator.IsPeselValid(""));
            Assert.IsFalse(checkPeselValidator.IsPeselValid(" "));
        }
    }

}
