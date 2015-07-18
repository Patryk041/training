using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.TrainingFour.Delegates;
using Toci.Hornets.GhostRider.TrainingFour.ExtensionMethods;

namespace Toci.Hornets.UnitTests.GhostRider.TrainingFour
{
    [TestClass]
    public class DelegatesRunner
    {
        [TestMethod]
        public void RuneDelegatesTEsts()
        {
            //DelegateExamples del = new DelegateExamples();

            //del.Test();

            DelegateClient cl = new DelegateClient();

            var delegates = cl.GetDelegatesStack();

            //delegates += TestowaZabawa;


            //cl.InjectDelegate();


            delegates("fgdwghfdshhfdfd", null); // 1
            delegates("fgdwghfdshhfdfd", null); // 1
        } // 5

        [TestMethod]
        public void TestLinqPreShowdown()
        {
            var lista = new string[] {"dfsafadsfds", "fsdadafd", "fdsagfdsgsdf", "ale zabawa"};

            var result = lista.ShowHowLinqWorks("fdsagfdsgsdf", (x, x2) => x == x2 ? x2 : null);

            //lista.Where()
            var test = result.Count();

        }

        private bool LinqDelegate(string parameter, string str)
        {
            return parameter == str; //???
        }

        private void TestowaZabawa(string gdsafads)
        { // 4
            
        }
    }
}