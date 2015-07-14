using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Vernathic.TrainingTwo;

namespace Toci.Hornets.UnitTests.Bytom.Vnth
{
	[TestClass]
	public class VnthPeselValidatorTest
	{
		[TestMethod]
		public void VPeselValidatorTestMethod()
		{
			var validator = new VnthPeselValidator();

			Assert.IsTrue(validator.IsPeselValid("92051414608"));
			Assert.IsTrue(validator.IsPeselValid("92090607249"));
			Assert.IsTrue(validator.IsPeselValid("39030719172"));
			Assert.IsTrue(validator.IsPeselValid("75110913971"));
		}
	}
}
