using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.rbedkowski.Pesel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.rbedkowski
{
   
    public class TestPesel
    {
        
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
