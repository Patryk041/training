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
            RudiBankTransferParser tak = new RudiBankTransferParser("..\\..\\..\\Toci.Hornets.Gliwice\\PracaZespolowa\\PrzelewyBankowe\\Didi\\DidiPrzelewy.txt");

            foreach(String str in tak.listaPrzelewow)
            Console.Write(str);
        }
    }
}
