using System;
using System.Collections.Generic;
using System.IO;

namespace Startup.TrainingOneHomeworks.Erloon
{
    public static class BamkList
    {
        public static List<Bank> ListAllBank
        {
            get { return ImportListFromText(); }
        }



        public static List<Bank> ImportListFromText()
        {
            var banks = new List<Bank>();

            foreach (var line in File.ReadAllLines("NbpList.txt"))
            {
                var columns = line.Split('\t');
                banks.Add(new Bank
                {
                    AppliedIdeniyfiers = int.Parse(columns[0]),
                    BankName = columns[1],
                    InstytutinName = columns[2], //nazwa centrali
                    RangeIdInstitutions = columns[3], //zakres id instytucji
                    BranchBankId = columns[4],
                    BranchBankName = columns[5],
                    ShortBranchName = columns[6],
                    City = columns[7],
                    Street = columns[8],
                    PostalCode = columns[9],
                    Pob = short.Parse(columns[10]),
                    AreaNumber = short.Parse(columns[11]),
                    PhoneNumber1 = Int32.Parse(columns[12]),
                    PhoneNumber2 = Int32.Parse(columns[13]),
                    FaxNumber1 = Int32.Parse(columns[14]),
                    FaxNumber2 = Int32.Parse(columns[15]),
                    CreateDate = columns[16],
                    Bic = columns[16],
                    SepaBic = columns[17],
                    Website = columns[18],
                    Province = columns[19],
                    HomeCity = columns[20],
                    CorrespondenceCity = columns[21],
                    CorrespondenceStreet = columns[22],
                    CorrespondencePostalCode = columns[23],
                    CorrespondenceCity2 = columns[24],
                    unidentified1 = short.Parse(columns[25]),
                    unidentified2 = short.Parse(columns[26]),
                    unidentified3 = short.Parse(columns[27]),
                    SortCode = Int32.Parse(columns[28]),
                });
            }

            return banks;
        }
    }
}