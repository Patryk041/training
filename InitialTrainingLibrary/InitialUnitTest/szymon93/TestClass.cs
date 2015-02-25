using System;
using InitialTrainingLibrary.szymon93._1__DateValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.szymon93
{
	[TestClass]
	class TestClass
	{
		[TestMethod]
		public void DateValidatorTestMethod()
		{
			DateValidator dateValidator = new DateValidator();

			Assert.IsFalse(dateValidator.DateValidate(2013, 13, 24));
			Assert.IsTrue(dateValidator.DateValidate(2013, 7, 13));
			Assert.IsFalse(dateValidator.DateValidate(-1, 4, 5));
			Assert.IsTrue(dateValidator.DateValidate(1999, 10, 31));
			Assert.IsTrue(dateValidator.DateValidate(2002, 5, 18));
			Assert.IsTrue(dateValidator.DateValidate(2000, 1, 1));
			Assert.IsFalse(dateValidator.DateValidate(2000, 1, 0));
			Assert.IsTrue(dateValidator.DateValidate(1410, 7, 15));
			Assert.IsTrue(dateValidator.DateValidate(1, 1, 1));
			Assert.IsFalse(dateValidator.DateValidate(2401, 24, 8));
		}
	}
}
