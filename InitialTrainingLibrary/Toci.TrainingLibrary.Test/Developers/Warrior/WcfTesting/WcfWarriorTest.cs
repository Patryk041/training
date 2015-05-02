using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TrainingLibrary.Test.WarriorWcf;

namespace Toci.TrainingLibrary.Test.Developers.Warrior.WcfTesting
{
    [TestClass]
    public class WcfWarriorTest
    {
        [TestMethod]
        public void TestWcfByWarrior()
        {
            IService1 wcf = new Service1Client();

            //var result = wcf.GetDataUsingDataContract(new CompositeType() {BoolValue = true});
            var cTYpe = new CompositeType() {BoolValue = true};

            cTYpe.Path = @"c:\Warrior.txt";
            cTYpe.WarriorDelegateFun = TEst;

            wcf.WarriorWcfFun(cTYpe);

            cTYpe.Path = @"Warrior.txt";
            cTYpe.WarriorDelegateFun = TEst;

            wcf.WarriorWcfFun(cTYpe);

            var result = cTYpe;
        }

        private bool TEst(string paTH)
        {
            StreamWriter wr = new StreamWriter(paTH);

            wr.WriteLine("a kuku ! :)");
            wr.Close();

            return true;
        }
    }
}
