using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup.TrainingOneHomeworks.Vertek.AccountNumberValidation
{
    public abstract class ValidateAccountNumber
    {

        private string[] AccountNumbers = new string[5]
        {
            "86102024123458860123531234",
            "76130024980234620202631234",
            "66175024980000863444444234",
            "26216024980734660204534534",
            "36249024567340860202631234"
        };
        private Dictionary<int, string> BankCode = new Dictionary<int, string>();
        string BankName;
        public string CheckNumber(int code)
        {
            UpdateDictionary();
            BankCode.TryGetValue(code, out BankName);
            return BankName;
        }

        private void UpdateDictionary()
        {
            //86 10202498 000086020263XXXX
            BankCode.Add(1010, "Narodowy Bank Polski"); 
            BankCode.Add(1020, "PKO BP");
            BankCode.Add(1030, "Citybank Handlowy");
            BankCode.Add(1050, "ING");
            BankCode.Add(1060, "BPH");
            BankCode.Add(1090, "BZ WBK");
            BankCode.Add(1130, "BGK");
            BankCode.Add(1140, "mBank");
            BankCode.Add(1160, "Bank Milennium");
            BankCode.Add(1240, "Pekao");
            BankCode.Add(1280, "HSBC");
            BankCode.Add(1300, "Meritum Bank");
            BankCode.Add(1320, "Bank Pocztowy");
            BankCode.Add(1440, "Nordea Bank");
            BankCode.Add(1470, "Euro Bank");
            BankCode.Add(1540, "BOŚ");
            BankCode.Add(1580, "Mercedes-Benz Bank Polska");
            BankCode.Add(1600, "BNP Paribas Fortis");
            BankCode.Add(1610, "SGB - Bank");
            BankCode.Add(1670, "RBS Bank(Polska)");
            BankCode.Add(1750, "Raiffeisen Bank");
            BankCode.Add(1840, "Societe Generale");
            BankCode.Add(1870, "FM Bank PBP");
            BankCode.Add(1910, "Deutsche Bank Polska");
            BankCode.Add(1930, "Bank Polskiej Spółdzielczości");
            BankCode.Add(1940, "Credit Agricole Bank Polska");
            BankCode.Add(1950, "Idea Bank");
            BankCode.Add(2000, "Rabobank Polska");
            BankCode.Add(2030, "BGŻ");
            BankCode.Add(2070, "FCE Bank Polska");
            BankCode.Add(2120, "Santander Consumer Bank");
            BankCode.Add(2130, "Volkswagen Bank");
            BankCode.Add(2140, "Fiat Bank Polska");
            BankCode.Add(2160, "Toyota Bank");
            BankCode.Add(2190, "DnB Nord");
            BankCode.Add(2480, "Gettin Noble Bank");
            BankCode.Add(2490, "Alior Bank");
        }
    }
}
