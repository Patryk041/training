using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir;

namespace Toci.Hornets.UnitTests.Legnica.Kir.Files
{
    [TestClass]
    public class PrepareBankTransfer
    {
        private const int CountOfBanks = 4;
        private const int LengthOfBankNumber = 26;
        private char[] _chars = "0123456789".ToCharArray();
        private Random _random = new Random();

        private List<string> _banks = new List<string>()
        {
            "Bzwbk","Ing","Nordea","Pekao"
        };

        [TestMethod]
        public void PrepareFiles()
        {
            StreamWriter sw = File.CreateText(@"..\\..\\..\\Toci.Hornets.Legnica\\zadania_grupowe\\Legnica_Kir\\Files\\BankTransfersToDo\\Nordea\\Nordea.Txt");
            Random random = new Random();
            for (int i = 0; i < 200; i++)
            {
                var bankTransfer = new LegnicaBankTransfer
                {
                    DestinationBank = _banks[random.Next(CountOfBanks)],
                    SourceBank = _banks[random.Next(CountOfBanks)],
                    DestinationBankNumber = GenerateBankNumber(),
                    SourceBankNumber = GenerateBankNumber(),
                    Amount = random.Next(5000),
                    Date = GenerateBankTransferDate()
                };
                sw.WriteLine(bankTransfer);
            }
            sw.Close();
        }

        private string GenerateBankNumber()
        {
            return new string(
               Enumerable.Repeat(_chars, LengthOfBankNumber)
              .Select(s => s[_random.Next(s.Length)])
              .ToArray());
        }

        private DateTime GenerateBankTransferDate()
        {
            DateTime start = new DateTime(2010, 6, 5);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));
        }
    }
}