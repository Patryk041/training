using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Chojnecki.Kir;

namespace Toci.Hornets.UnitTests.Rzeszow.Chojnecki.Bank
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var operacja = new AndrzejFileOperation();
            Debug.WriteLine(operacja.GetFileContent("C:\\Hornets\\Hornets\\training\\Toci.Hornets.GhostRider\\Toci.Hornets.Rzeszow\\Chojnecki\\Kir\\Przelewy.txt"));
            Debug.WriteLine(operacja.GetFileContent("C:\\Hornets\\Hornets\\training\\Toci.Hornets.GhostRider\\Toci.Hornets.Rzeszow\\Chojnecki\\Kir\\x.xml"));
            var operacja2 = new AndrzejBankTransfersParser();
            Debug.WriteLine(operacja2.GetBankTransfers());
        }
    }
}