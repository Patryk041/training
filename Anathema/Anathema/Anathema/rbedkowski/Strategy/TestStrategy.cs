using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Strategy
{
    [TestClass]
    public class TestStrategy
    {
        [TestMethod]
        public void MainTest()
        {
            List<IAction> list = new List<IAction>();
            list.Add(new Driver());
            list.Add(new Pilot());
            list.Add(new Sailor());

            foreach (var test in list)
                Console.WriteLine(test.GetAction());
            
        }
    }
}
