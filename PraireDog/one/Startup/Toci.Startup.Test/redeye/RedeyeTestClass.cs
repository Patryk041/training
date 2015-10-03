using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank;
using Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank.Interfaces;


namespace Toci.Startup.Test.redeye
{
    [TestClass]
    public class RedeyeTestClass
    {
        [TestMethod]
        public void DoThings()
        {
            PolishDictionaryFromFile test = new PolishDictionaryFromFile();
            // @"http://www.nbp.pl/banki_w_polsce/ewidencja/dz_bank_jorg.txt"

            //test.MakeDictionary(@"http://www.nbp.pl/banki_w_polsce/ewidencja/dz_bank_jorg.txt", Encoding.GetEncoding(852));

            ICheckBankFromNrAccount test2 = new PolishCheckAccount();
            test2.GetNameOfBank("PL77 1090 1362 0000 0000 3601 7903");

        }
    }
}