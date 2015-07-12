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
            var newPesel = new AndrzejPeselValidator();

            //Cyfra kontrolna i sprawdzanie poprawności numeru
            Assert.IsTrue(newPesel.IsPeselValid("94120807274"));
            Assert.IsTrue(newPesel.IsPeselValid("93122305155"));
            Assert.IsFalse(newPesel.IsPeselValid("94120807275"));
            Assert.AreEqual("08", DateMenger.GetDay("94120807274"));
            Assert.AreEqual("1994", DateMenger.GetYear("94120807274"));
            Assert.AreEqual("12", DateMenger.GetMonth("94120807274"));
            Assert.AreEqual("08121994", DateMenger.GetDate("94120807274"));

            Assert.AreEqual("23", DateMenger.GetDay("93122305155"));
            Assert.AreEqual("1993", DateMenger.GetYear("93122305155"));
            Assert.AreEqual("12", DateMenger.GetMonth("93122305155"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(DateMenger.DayCheck(2013, 2, 29));
            Assert.IsTrue(DateMenger.DayCheck(2012, 2, 29));
            Assert.AreEqual(DateMenger.CutMonth(81), 1);
        }
    }
}