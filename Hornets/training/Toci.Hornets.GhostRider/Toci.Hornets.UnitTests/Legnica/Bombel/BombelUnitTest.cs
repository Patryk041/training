using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.Bombel.PeselValidator;
using Toci.Hornets.Legnica.Bombel.StringManipulator;

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

        [TestMethod]
        public void TestStringManipulator()
        {
            string subject = "Denis";
            string seek = "hitb686r";
            string seek1 = "sined";
            string seek2 = "denis";
            string seek3 = "si";
            string seek4 = "s";

            var Test = new BombelStringManipulator();

            Test.RunStringOperations(subject, seek);
            Test.RunStringOperations(subject, seek1);
            Test.RunStringOperations(subject, seek2);
            Test.RunStringOperations(subject, seek3);
            Test.RunStringOperations(subject, seek4);

        }
    }
}
