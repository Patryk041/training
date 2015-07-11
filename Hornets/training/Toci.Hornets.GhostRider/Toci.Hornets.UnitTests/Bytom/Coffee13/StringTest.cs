using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Coffee13.TaskTrainingTwo.StringManipulator;

namespace Toci.Hornets.UnitTests.Bytom.Coffee13
{
	[TestClass]
	public class StringTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			CoffeeStringManipulations test1 = new CoffeeStringManipulations();



			Assert.IsTrue(test1.RunStringOperations("beata", "ataeb").IsAnagram);
			Assert.IsTrue(test1.RunStringOperations("beata", "aea").IsStringElementsInString);
			Assert.IsTrue(test1.RunStringOperations("beata", "ata").IsStringInString);

		}
	}
}