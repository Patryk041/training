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

			string result = dictionary.Aggregate("cos", (key, instance) => key + instance.Key + " " +instance.Value + ", " );

			Assert.AreEqual("cosid int, nazwaBanku text, numerKonta string", result.Substring(0,result.Length-2));
		}

		[TestMethod]
		public void GetKeyAndValueFromDictionary()
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

			string result = dictionary.Aggregate("", (temp, instance) => temp + instance.Key + ", "); // to musimy uzyc tam w insercie wywalilo mnie z mumble
			var r = dictionary.Select(x => x.Key).ToArray();

			//Assert.AreEqual("id, nazwaBanku, numerKonta", result.Substring(0, result.Length-2));

			Assert.AreEqual("id, nazwaBanku, numerKonta", r[0]);
		}

	}

}
