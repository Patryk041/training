using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Dal.Models;
using Toci.Db.Clients;
using Toci.Db.ClusterAccess;
using Toci.Db.DbVirtualization.PostgreSqlQuery;

namespace Toci.TrainingLibrary.Test.Developers.Mg
{
    [TestClass]
    public class DbTest
    {

        [TestMethod]
        public void dataSetMapperTest()
        {
            var transferModel = new BankAccountTransferModel();

            var postgreDbHandle = new DbHandle(new PostgreSqlClient("postgres", "beatka", "localhost", "postgres"),
                new PostgreSqlSelect(), new PostgreSqlInsert(), new PostgreSqlUpdate(), new PostgreSqlDelete());

            transferModel.Id = 5;
            transferModel.Nazwa = "bzdura";

            transferModel.SetWhere(BankAccountTransferModel.NAZWA);
            var dataSetTest = postgreDbHandle.GetData(transferModel);

            var result = transferModel.GetDataRowsList(dataSetTest);

        }

        [TestMethod]
        public void db()
        {
            var model = new BankAccountTransferModel() {Id = 1, Nazwa = "dsyq"};
            model.SetWhere(BankAccountTransferModel.NAZWA);

            PostgreSqlSelect abc = new PostgreSqlSelect();
            var result= abc.GetQuery(model);


            Assert.AreEqual(result, "select id, nazwa from transfer  where nazwa Like 'dsyq'");

        }
    }
}
