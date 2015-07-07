using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL;

namespace Toci.Hornets.UnitTests.Rzeszow.Chojnecki.PeselTest
{
    [TestClass]
    public class PESELTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pesel_Validator newPesel = new Pesel_Validator();

            //Cyfra kontrolna i sprawdzanie poprawności numeru
            Assert.IsTrue(newPesel.IsPeselValid("94120807274"));
            Assert.IsFalse(newPesel.IsPeselValid("94120807275"));
            Calendar c = new Calendar("94120807274");
            Assert.AreEqual("08",c.getDay());
            Assert.AreEqual("1994",c.getYear());
            Assert.AreEqual("12",c.getMonth());
        }
    }
}
