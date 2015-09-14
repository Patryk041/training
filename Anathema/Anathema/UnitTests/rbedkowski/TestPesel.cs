using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.rbedkowski.Pesel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.rbedkowski
{
    [TestClass]
    class TestPesel
    {
        [TestMethod]
        public static void Main(string[] args)
        {
            PeselValidator pesel = new PeselValidator();

            try
            {
                Console.WriteLine(pesel.SetPesel("7406219896"));
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
