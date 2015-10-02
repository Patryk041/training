using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Client;
using Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model;
using Toci.Hornets.GhostRider.TrainingThree;
using Toci.Hornets.GhostRider.TrainingThree.Chor;

namespace Toci.Hornets.UnitTests.GhostRider.GeneralTests
{
    [TestClass]
    public class DebugingTesting 
    {
        [TestMethod]
        public void ALotOfDebuging()
        {
            BenchingOverriding bo = new BenchingOverriding();

            //bo.OverloadingExamplesTesting();
            bo.TestItAll();
        }

        [TestMethod]
        public void TestRefs()
        {
            OperacjeRefWar operacje = new OperacjeRefWar();

            operacje.AleZeMnieDebil();
        }


        [TestMethod]
        public void TEstDbCommunication()
        {
            PostgreSqlClient client = new PostgreSqlClient();

            var datasetResult = client.GetData("select * from TestsResultsView");
        }


        [TestMethod]
        public void TestFirstInsert()
        {
            ApplicationTestsModel exModel = new ApplicationTestsModel();
            DataStorageInsert insert = new DataStorageInsert();

            string command = insert.GetSetDataCommand(exModel);

            Assert.AreEqual(command, "insert into ApplicationTests (codesnipet, rightanswers, kolumnaliczbowa) values ('haha', 'idento', 3);");
        }
    }
}