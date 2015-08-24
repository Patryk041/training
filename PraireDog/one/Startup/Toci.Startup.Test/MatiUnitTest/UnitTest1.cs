using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Startup.TrainingOneHomeworks.Mati;
using Startup.TrainingOneHomeworks.Mati.Banks;

namespace Toci.Startup.Test.MatiUnitTest
{
    [TestClass]
    public class BankUnitTest
    {
        [TestMethod]
        public void CheckSearchAccount()
        {
            ClientTransaction transaction = new ClientTransaction();
            Assert.IsInstanceOfType(new AliorTransactionBank(), transaction.SearchAccount("1111").GetType());
            Assert.IsInstanceOfType(new BgzTransactionBank(), transaction.SearchAccount("1112").GetType());
        }
        [TestMethod]
        public void GetListTransactionIsNull()
        {
            ClientTransaction transaction = new ClientTransaction();
            Assert.IsNull(transaction.GetTransactions());
         //   Assert.IsNull(transaction.GetTransactions()[1].GetType());
        }
        [TestMethod]
        public void GetListTransaction()
        {
            ClientTransaction transaction = new ClientTransaction();
            Assert.IsInstanceOfType(new AliorTransactionBank(), transaction.GetTransactions()[0].GetType());
            Assert.IsInstanceOfType(new BgzTransactionBank(), transaction.GetTransactions()[1].GetType());
        }

        [TestMethod]
        public void IsCreatedDocumentXml()
        {
            BankTransaction bank1= new AliorTransactionBank();
            
            bank1.DescriptionTransaction();
        }

        protected List<BankTransaction> GetAllBankTransactions()
        {
            var result = Assembly.GetCallingAssembly().GetTypes().Where(item => item.IsSubclassOf(typeof (BankTransaction)));

            foreach (var item in result)
            {
                //item.
            }
        }
    }
}
