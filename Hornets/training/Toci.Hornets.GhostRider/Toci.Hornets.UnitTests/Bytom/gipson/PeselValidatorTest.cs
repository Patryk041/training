using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.gipson.Homework0407;

namespace Toci.Hornets.UnitTests.Bytom.gipson
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