using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Logic;

namespace Toci.TrainingLibrary.Test.Developers.Warrior
{
    [TestClass]
    public class WarriorMgSolutionTest
    {
        [TestMethod]
        public void MgWarriorMultiFileParserTest()
        {
            ParsersFactory factory = new ParsersFactory();

            factory.GetData();
        }
    }
}
