using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.InkNinja.TrainingFour;

namespace Toci.Hornets.UnitTests.Bytom.InkNinja
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			List<int> lista = new List<int>();

			var lista2 = new InkGenericTask<int>();

			Assert.IsFalse(lista2.Remove(3545));
			Assert.IsTrue(lista2.Add(345));

		}
	}
}
