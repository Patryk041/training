using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Coffee13.TaskTrainingTwo.PeselValidator;

namespace Toci.Hornets.UnitTests.Bytom.Vnth
{
	[TestClass]
	public class VnthFirstUnitTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var validator = new CoffeePeselValidator();

			Assert.IsTrue(validator.IsPeselValid("93031509503"));
			//Assert.IsTrue(false);

		}

		[TestMethod]
		public void MyTestMethod()
		{
			
		}
	}
}
