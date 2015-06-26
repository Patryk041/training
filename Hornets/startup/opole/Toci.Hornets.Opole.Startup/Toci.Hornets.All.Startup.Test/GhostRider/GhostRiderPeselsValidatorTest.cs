using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.TrainingTwo.Homework;

namespace Toci.Hornets.All.Startup.Test.GhostRider
{
    [TestClass]
    public class GhostRiderPeselsValidatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PeselValidator validator = new GhostRoderPeselValidator();

            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
            Assert.IsFalse(validator.IsPeselValid("43275672345432"));
        }
    }
}
