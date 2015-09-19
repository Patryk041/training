using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

namespace Anathema.rbedkowski.Pesel
{
    public class PeselValidator
    {
        private string NumerPesel { set; get; }
        private string Sex;
        public int NumerPeselNumeric;
        private int Year;
        private int Monath;
        private int Day;

        private int[] TableNumerPeselNumeric = new int[11];
        private int[] TableINT = new int[]{1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
        private int[] TabDay = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int[] TabYear = new int[] { 190, 190, 200, 200, 210, 210, 220, 220, 180, 180 };

        List<string> listPesel = new List<string>();

        public string SetPesel (string _pesel)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(_pesel), "Nie wprowadzono numeru pesel.");
            Contract.Requires(!(_pesel.Length < 11), "Numer pesel powinien zawierać 11 cyfr.");
            Contract.Requires(!int.TryParse(_pesel, out NumerPeselNumeric), "Numer pesel zawiera niedozwolone znaki.");
            Contract.Requires(CheckSum(_pesel), "Nieprawidłowa suma kontrolna w numerze pesel.");
            Year = SetYear();
            Contract.ReferenceEquals(SetMonath() <= 12, "Nieprawidłowa wartośc na pozycji miesiac." );
            Monath = SetMonath();
            Contract.ReferenceEquals(SetDay() <= TabDay[SetMonath()-1], "Nieprawidłowa wartośc na pozycji dzien.");
            Day = SetDay();
            NumerPesel = _pesel;
            Sex = SetSex();

            return _pesel;
        }

        public bool CheckSum(string _pesel)
        {
            int sum=0;
            for (int counter = 0; counter < TableNumerPeselNumeric.Length; counter++)
                TableNumerPeselNumeric[counter] = (int)Char.GetNumericValue(_pesel[counter]);
            for (int counter = 0 ; counter < (TableINT.Length); counter++)
            {
                sum = sum + (TableNumerPeselNumeric[counter] * TableINT[counter]);
            }
                
            if ((sum % 10) == 0)
				sum = 0;
				else
					sum = 10 -sum % 10;
            if (sum == TableNumerPeselNumeric[10])
				return true;
			else 
                return false;
        }

        private List<string> GetFromFile ()
        {

            List<string> listPesel = new List<string>();
            FileStream file = new FileStream("NrPesel.txt", FileMode.Open, FileAccess.Read);

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        listPesel.Add(sr.ReadLine());
                    }

                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return listPesel;
        }

        private int SetYear ()
        {
            return (TabYear[TableNumerPeselNumeric[2]] + TableNumerPeselNumeric[0]) * 10 + TableNumerPeselNumeric[1];
        }

        private int SetMonath()
        {
            int i = 0;
            if (TableNumerPeselNumeric[2] % 2 == 0)
              i = 0;
              else i = 1;
            return TableNumerPeselNumeric[2] * 10 + TableNumerPeselNumeric[3] - ((TableNumerPeselNumeric[2]-i) * 10);
        }

        private string SetSex ()
        {
            if (TableNumerPeselNumeric[9] % 2 == 0)
                return "Famale";
            return "Male";
        }

        private int SetDay()
        {
            return TableNumerPeselNumeric[4] * 10 + TableNumerPeselNumeric[5];
        }

        private bool LeapYear (int _year)
        {
            if (((_year % 4 == 0) & (_year % 100 != 0) ) || (_year % 400 == 0) )
                return true;
            return false;
        }

        public void ShowPesel(string _pesel)
        {
            SetPesel(_pesel);
            Console.WriteLine("Pesel : {0}", NumerPesel);
            Console.WriteLine("Rok: {0}  " + "Miesiac : {1}  " + "Dzien : {2}  " + "Plec : {3}", Year, Monath, Day, Sex );
            Console.WriteLine("<========================================================>");
        }

        public void ShowPeselFromFile()
        {
            foreach (string _pesel in GetFromFile())
                ShowPesel(_pesel);

        }
    }
}
