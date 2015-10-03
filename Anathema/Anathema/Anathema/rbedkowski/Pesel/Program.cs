using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Pesel.Pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            PeselValidator pesel = new PeselValidator();

            try
            {
                pesel.ShowPesel("74062109896");
                pesel.ShowPeselFromFile();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nieprawidłowy numer pesel : " + e.Message);
            }
            
            Console.Read();
        }
    }
}
