using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Coffee13.TaskTrainingTwo.PeselValidator;

namespace Toci.Hornets.UnitTests.Bytom.Coffee13
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var test1 = new CoffeePeselValidator();
			var test2 = new CoffeePeselValidator();

			Assert.IsTrue(test1.IsPeselValid("91071508250"));
			Assert.IsFalse(test2.IsPeselValid("44051401453"));
		}
	}
}