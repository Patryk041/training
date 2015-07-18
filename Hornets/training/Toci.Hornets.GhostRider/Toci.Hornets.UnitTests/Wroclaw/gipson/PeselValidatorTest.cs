using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Wroclaw.AdamPast.Homework0407;

namespace Toci.Hornets.UnitTests.Wrocław.gipson
{
    [TestClass]
    public class PeselValidatorTest
    {
        [TestMethod]
        public void PeselValidatorTestMethod()
        {
            GipsonPeselValidator vd = new GipsonPeselValidator();
            Assert.IsTrue(vd.IsPeselValid("91930110450"));
        }
    }
}