using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi;

namespace Toci.Hornets.UnitTests.Gliwice.Rudi
{
    [TestClass]
    public class RudiBankTransferParserTest
    {
        [TestMethod]
        public void FileReadTest()
        {
            RudiBankTransferParser tak = new RudiBankTransferParser();
            Console.Write(tak.listaPrzelewow.ToString());

        }
    }
}
