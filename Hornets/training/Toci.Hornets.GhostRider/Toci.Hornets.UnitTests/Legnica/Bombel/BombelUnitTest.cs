using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.Bombel.PeselValidator;

namespace Toci.Hornets.UnitTests.Legnica.Bombel
{
    [TestClass]
    public class BombelUnitTest
    {
        [TestMethod]
        public void TestPeselValidator()
        {
            var validator = new BombelPeselValidator();

            Assert.IsTrue(validator.IsPeselValid("93101901138"));
            Assert.IsTrue(validator.IsPeselValid("69910200924"));
            Assert.IsTrue(validator.IsPeselValid("09062809286"));

            Assert.IsFalse(validator.IsPeselValid("44051401358"));
            Assert.IsFalse(validator.IsPeselValid("4405140158"));
            Assert.IsFalse(validator.IsPeselValid("93131901138"));
        }
    }
}
