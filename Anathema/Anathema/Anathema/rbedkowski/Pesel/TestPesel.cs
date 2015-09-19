using System;

namespace Anathema.rbedkowski.Pesel
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
