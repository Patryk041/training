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
            Assert.AreEqual("08", DateMenager.GetDay("94120807274"));
            Assert.AreEqual("1994", DateMenager.GetYear("94120807274"));
            Assert.AreEqual("12", DateMenager.GetMonth("94120807274"));
            Assert.AreEqual("08121994", DateMenager.GetDate("94120807274"));

            Assert.AreEqual("23", DateMenager.GetDay("93122305155"));
            Assert.AreEqual("1993", DateMenager.GetYear("93122305155"));
            Assert.AreEqual("12", DateMenager.GetMonth("93122305155"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(DateMenager.DayCheck(2013, 2, 29));
            Assert.IsTrue(DateMenager.DayCheck(2012, 2, 29));
            Assert.AreEqual(DateMenager.CutMonth(81), 1);
        }
    }
}