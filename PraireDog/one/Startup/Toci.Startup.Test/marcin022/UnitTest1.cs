using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Startup.TrainingOneHomeworks.marcin022;
namespace Toci.Startup.Test.marcin022
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BankValidate obj = new BankValidate("67 1160 2202 0000 0002 4649 1924");
        }
    }
}
