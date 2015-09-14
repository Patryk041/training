using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Pesel
{
    public class PeselValidator
    {
        private string NumerPesel { set; get; }
        private int NumerPeselNumeric;
        private int Montah;
        private int Day;

        private int[] TableNumerPeselNumeric;
        List<string> listPesel = new List<string>();


        public string SetPesel(string _pesel)
        {
            int NumerPeselNumeric;
            Contract.Requires(!string.IsNullOrWhiteSpace(_pesel), "Nie wprowadzono numeru pesel.");
            Contract.Requires(!(_pesel.Length < 11), "Numer pesel powinien zawierać 11 cyfr");
            Contract.Requires(!int.TryParse(_pesel, out NumerPeselNumeric), "Numer pesel zawiera niedozwolone znaki");
            Console.WriteLine(_pesel.Length);
            return _pesel;
        }

        public List<string> GetNumberFromFile()
        {

            List<string> listPesel = new List<string>();
            FileStream file = new FileStream("NrPesel.txt", FileMode.Open, FileAccess.Read);

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int counter = 0;
                    while (sr.ReadLine() != null)
                    {
                        listPesel[counter] = sr.ReadLine();
                        counter++;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return listPesel;
        }

        private void SetYear()
        {

        }

        private void SetMonath()
        {

        }

        private void SetDay()
        {

        }
    }
}
