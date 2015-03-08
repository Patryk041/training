using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingThree.Polimorphism;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Db.Clients;

namespace Toci.TrainingLibrary.Test.Developers.Warrior.Db
{
    [TestClass]
    public class DbOperationsTest
    {
        [TestMethod]
        public void TestRandomSelect()
        {
           // PostgreSqlClient client = new PostgreSqlClient("postgres", "beatka", "localhost", "postgres");

          //  var result = client.GetData("select * from chmura;");

            TransfersSaveLogic transfersSave = new TransfersSaveLogic();
            transfersSave.ParseTransfers();
        }
    }
}
