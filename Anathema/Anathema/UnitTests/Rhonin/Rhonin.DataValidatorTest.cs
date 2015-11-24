using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anathema.Rhonin.DataValidator;

namespace UnitTests.Rhonin
{
    [TestClass]
    public class Rhonin
    {
        [TestMethod]
        public void TestDataValidator()
        {
            RhoninDataValidator validator = new RhoninDataValidator();
            //Dictionary<int, List<int>> dates = new Dictionary<int, List<int>>()
            //{
            //    {1, new List<int> {2012,2,22 } },
            //};

            Assert.IsTrue(validator.DateValidate(2012, 3, 11));
            Assert.IsTrue(validator.DateValidate(2012, 2, 29));
            Assert.IsFalse(validator.DateValidate(2012, 2, 30));
            Assert.IsFalse(validator.DateValidate(2012, -2, 30));
            Assert.IsFalse(validator.DateValidate(2012, 2, -3));
            Assert.IsFalse(validator.DateValidate(-2012, 2, 5));
            
        }
    }
}
