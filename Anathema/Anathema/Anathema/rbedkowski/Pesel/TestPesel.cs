using System;

namespace Anathema.rbedkowski.Pesel
{

    class TestPesel
    {
        
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
