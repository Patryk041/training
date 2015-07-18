using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Wroclaw.Ayuu.TrainingTwo;

namespace Toci.Hornets.UnitTests.Wroclaw.Ayuu
{
    [TestClass]
    public class AyuuPeselValidatorTest
    {        

        [TestMethod]
        public void PeselValidatorTestMethod()
        {
            AyuuPeselValidator apv = new AyuuPeselValidator();
            Assert.IsTrue(apv.IsPeselValid("74021834018"));
            Assert.IsTrue(apv.IsPeselValid("02070803628"));
            Assert.IsTrue(apv.IsPeselValid("74021834001"));
            Assert.IsFalse(apv.IsPeselValid("74021834012"));
            Assert.IsFalse(apv.IsPeselValid("91130110450"));
            Assert.IsFalse(apv.IsPeselValid("46040501580"));
        } 
    }
}