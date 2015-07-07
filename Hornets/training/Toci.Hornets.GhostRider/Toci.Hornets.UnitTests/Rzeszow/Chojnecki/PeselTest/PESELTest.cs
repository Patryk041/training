using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Chojnecki.TrainingTwoPESEL;

namespace Toci.Hornets.UnitTests.Rzeszow.Chojnecki.PeselTest
{
    [TestClass]
    public class PeselTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyPeselValidator newPesel = new MyPeselValidator();

            //Cyfra kontrolna i sprawdzanie poprawności numeru
            Assert.IsTrue(newPesel.IsPeselValid("94120807274"));
            Assert.IsFalse(newPesel.IsPeselValid("94120807275"));
            Calendar c = new Calendar("94120807274");
            Assert.AreEqual("08",c.GetDay());
            Assert.AreEqual("1994",c.GetYear());
            Assert.AreEqual("12",c.GetMonth());
        }
    }
}
