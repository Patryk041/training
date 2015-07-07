using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW;

namespace Toci.Hornets.UnitTests.Kalisz.Adrianowsky94
{
    [TestClass]
    public class PeselTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            A94PeselValidator peselValidator = new A94PeselValidator();

            peselValidator.IsPeselValid("02102897014");
        }
    }
}
