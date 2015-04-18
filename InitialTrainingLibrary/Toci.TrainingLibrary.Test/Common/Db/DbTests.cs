using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Dal.Models;
using Toci.Db.ClusterAccess;
using Toci.Db.DbVirtualization.MsSqlQuery;
using Toci.Db.Interfaces;

namespace Toci.TrainingLibrary.Test.Common.Db
{
    [TestClass]
    public class DbTests
    {
        [TestMethod]
        public void MsSqlInsertTranferTest()
        {
            BankAccountTransferModel model = new BankAccountTransferModel();
            model.Id = 1;
            MsSqlInsert insert = new MsSqlInsert();
            var cokolwiek = insert.GetQuery(model);
            Assert.AreEqual(cokolwiek, "insert into transfer (id) values (1);");
        }

        [TestMethod]
        public void DbHandleInsertTransferTest()
        {

            IDbHandle handle = DbHandleFactory.GetHandle(SqlClientKind.MsSql,  "", "", ".\\SQLEXPRESS", "toci");
            
            handle.InsertData(new BankAccountTransferModel(){Id = 1});
        }
    }
}
