using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.UnitTests.GhostRider.Abstraction;

namespace Toci.Hornets.UnitTests.GhostRider.PeselTask
{
    [TestClass]
    public class PeselTaskTest : TestBase
    {
        private List<string> TestPesels = new List<string>
        {
            "11241411113",
            "84080818074",
            "84022814744"
        };

        [TestMethod]
        public void TestAllPesels()
        {
            var items = GetDerivingTypes<PeselValidator>();

            foreach (var item in items)
            {
                foreach (var element in TestPesels)
                {
                    try
                    {
                        var result = item.IsPeselValid(element);
                        Debug.WriteLine("{0} said the pesel {1} is {2}", item.GetNick(), element, result);
                    }
                    catch
                    {
                        
                    }
                }
            }
        }
    }
}