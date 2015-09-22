using System;
using Anathema.rbedkowski.Pesel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.rbedkowski
{
    [TestClass]
    public class TestPesel
    {
        [TestMethod]
        public void MainTest()
        {
            PeselValidator pesel = new PeselValidator();

            try
            {
                Console.WriteLine(pesel.SetPesel("740621a9896"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Nieprawidłowy pesel : " + e.Message);
            }
            //       pesel.GetNumberFromFile();
            Console.Read();
        }
    }
}
