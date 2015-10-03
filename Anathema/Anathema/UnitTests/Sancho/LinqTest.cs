using System;
using System.Collections.Generic;
using Anathema.Sancho.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Sancho
{
	[TestClass]
	public class LinqTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var link = new SuperLinq();

			var result = link.GetUsernamesByValue("Architect");
		}
	}
}
