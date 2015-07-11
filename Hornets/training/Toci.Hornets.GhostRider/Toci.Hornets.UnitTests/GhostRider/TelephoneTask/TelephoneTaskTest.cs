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
