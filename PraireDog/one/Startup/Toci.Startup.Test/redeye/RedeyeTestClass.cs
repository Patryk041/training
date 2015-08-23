using Microsoft.VisualStudio.TestTools.UnitTesting;
using Startup.redeye.IdentyficationOfBank;
using Startup.redeye.IdentyficationOfBank.Interfaces;


namespace Toci.Startup.Test.redeye
{
    [TestClass]
    public class RedeyeTestClass
    {
        [TestMethod]
        public void DoThings()
        {
            IGetFile test = new FileWidthData();
            test.GetFile();
        }
    }
}