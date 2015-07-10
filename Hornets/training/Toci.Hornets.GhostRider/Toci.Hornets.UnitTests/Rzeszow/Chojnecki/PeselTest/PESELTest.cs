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
            Assert.IsTrue(newPesel.IsPeselValid("93122305155"));
            Assert.IsFalse(newPesel.IsPeselValid("94120807275"));
            Calendar c = new Calendar("94120807274");
            Assert.AreEqual("08",c.GetDay());
            Assert.AreEqual("1994",c.GetYear());
            Assert.AreEqual("12",c.GetMonth());

            Calendar c2 = new Calendar("93122305155");
            Assert.AreEqual("23", c2.GetDay());
            Assert.AreEqual("1993", c2.GetYear());
            Assert.AreEqual("12", c2.GetMonth());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(Calendar.dayCheck(2013, 2, 29));
            Assert.IsTrue(Calendar.dayCheck(2012, 2, 29));

        }
    }
}
