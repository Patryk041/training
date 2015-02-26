using InitialTrainingLibrary.Sito._1;
using InitialTrainingLibrary.Sito._2;
using InitialTrainingLibrary.Sito._2.interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.Sito
{
    /// <summary>
    /// Summary description for SitoTest
    /// </summary>
    [TestClass]
    public class SitoTest
    {

        [TestMethod]
        public void SitoTestMethod()
        {
            DateValidator validator = new DateValidator();

            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2015, 02, 29));
            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 30));
            Assert.IsFalse(validator.DateValidate(2014, 09, 32));
            Assert.IsTrue(validator.DateValidate(2014, 06, 10));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 02, 29));
            Assert.IsTrue(validator.DateValidate(2014, 02, 28));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2014, 13, 31));
            Assert.IsFalse(validator.DateValidate(2014, 12, 32));
            Assert.IsTrue(validator.DateValidate(2014, 12, 31));
            Assert.IsFalse(validator.DateValidate(2014, 04, 31));
            Assert.IsFalse(validator.DateValidate(2015, 02, 29));
        }
        [TestMethod]
        public void SitoChessTestMethod()
        {
            Board board = new Board();
        }
    }
}
