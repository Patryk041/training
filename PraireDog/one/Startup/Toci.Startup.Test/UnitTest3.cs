using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Toci.Startup.Test
{
	[TestClass]
	public class UnitTest3
	{
		[TestMethod]
		public void TestMethod1()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>()
			{
				{
					"id", "int"
				},
				{
					"nazwaBanku", "text"
				},
				{
					"numerKonta", "string"
				}

			};
		
			string result = dictionary.Aggregate("", (key, instance) => key+(instance.Key + " " +instance.Value + ", "));

			Assert.AreEqual("id int, nazwaBanku text, numerKonta string", result.Substring(0,result.Length-2));
		}
	}
}
