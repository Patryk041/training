using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.PeselValidatorTest
{
    [TestClass]
    public class TerryPeselValidatorTest
    {
        [TestMethod]

        public void PeselTest()
        {
            TerryPeselValidator pesel = new TerryPeselValidator();
            Assert.IsTrue(pesel.IsPeselValid("45912400723"));
        }
    }
}
