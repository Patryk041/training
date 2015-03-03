using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using InitialTrainingLibrary.robson;


namespace InitialUnitTest.robson
{
    [TestClass]
    public class DateValidator
    {
        [TestMethod]
        public void TestGetName()
        {
            Date testObject = new Date();
            Assert.AreEqual("Robert Winkler", testObject.GetName());
        }


        [TestMethod]
        public void TestCheckIfLeap()
        {
            Date testObject = new Date();
            
            Assert.IsFalse(testObject.CheckIfLeap(2013));
            Assert.IsTrue(testObject.CheckIfLeap(2016));
            Assert.IsFalse(testObject.CheckIfLeap(1900));
            Assert.IsTrue(testObject.CheckIfLeap(1600));
        }

        [TestMethod]
        public void TestDateValidate()
        {
            Date testDate = new Date();
            Assert.IsFalse(testDate.DateValidate(1600, 2, 30));
            Assert.IsTrue(testDate.DateValidate(1600, 2, 29));
            Assert.IsTrue(testDate.DateValidate(1600, 2, 28));

            Assert.IsFalse(testDate.DateValidate(2001, 2, 29));
            Assert.IsTrue(testDate.DateValidate(2015, 2, 23));
            Assert.IsFalse(testDate.DateValidate(-1, 2, 28));
            Assert.IsFalse(testDate.DateValidate(-1, 2, 28));
            Assert.IsFalse(testDate.DateValidate(1, -2, 28));
            Assert.IsFalse(testDate.DateValidate(1, 2, -28));

            Assert.IsTrue(testDate.DateValidate(2009, 12, 30));
            Assert.IsTrue(testDate.DateValidate(2015, 02, 28));
            Assert.IsTrue(testDate.DateValidate(2015, 08, 01));
            Assert.IsTrue(testDate.DateValidate(2015, 07, 31));

            Assert.IsFalse(testDate.DateValidate(-1, 12, 30));
            Assert.IsFalse(testDate.DateValidate(2014, 02, 30));
            Assert.IsFalse(testDate.DateValidate(2010, 04, 31));
        }
    }
}
