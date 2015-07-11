using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;
using System.Reflection;
using Toci.Hornets.UnitTests.GhostRider.Abstraction;

namespace Toci.Hornets.UnitTests.GhostRider.TelephoneTask
{

	[TestClass]
	public class TelephoneTaskTest
	{
		[TestMethod]
		public void TestAllPeopleTask()
		{
			var elements = GetAllInterpreters();

			foreach (var element in elements)
			{
				element.GetUserChoice(2);
			}
		}

		private IEnumerable<TelephoneInterpreter> GetAllInterpreters()
		{

			List<TelephoneInterpreter> objects = new List<TelephoneInterpreter>();

			var assebmlies = AppDomain.CurrentDomain.GetAssemblies();

			var myAssemblies = new List<Assembly>();

			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Bytom"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Gliwice"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Kalisz"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Legnica"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Opole"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Rzeszow"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Sieradz"));
			myAssemblies.Add(AppDomain.CurrentDomain.Load("Toci.Hornets.Wroclaw"));

			//GetAssembly(typeof(TelephoneInterpreter))
			foreach (var item in myAssemblies)
				foreach (Type type in item.GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(TelephoneInterpreter))))
				{
					objects.Add((TelephoneInterpreter)Activator.CreateInstance(type));
				}

			return objects;
		}
	}
}

    [TestClass]
    public class TelephoneTaskTest : TestBase
    {
        [TestMethod]
        public void TestAllPeopleTask()
        {
            var elements = GetDerivingTypes<TelephoneInterpreter>();

            foreach (var element in elements)
            {
                element.GetUserChoice(2);
            }
        }


    }
}

