using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Gliwice.Didi.PeselTask
{
    public class ValidationPeselClass : PeselValidator
    {
        private List<string> _peselList; 
        private static readonly List<int> _ListaWag = new List<int>(){ 1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
        private DataClass _data;

        protected override string CutOffDate(string pesel)
        {
            return Check(pesel) ? pesel.Substring(0, 4) : "Niepoprawny pesel";
        }

        protected override bool Checksum(string pesel)
        {
            int sum = 0; 
            // ReSharper disable once LoopCanBeConvertedToQuery
            for (int i = 0; i < _peselList.Count; i++)
            {
                if (i < 10)
                {
                    sum += Int32.Parse(_peselList[i])*_ListaWag[i];
                }
            }
            sum = 10 - (sum%10);
            if (sum == 10)
            {
                sum = 0; 
            }
            return sum == Int32.Parse(_peselList.Last()); 
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
           _data = new DataClass(year, month, day);
           return _data.ValidateDate(); 
        }

        public override string GetNick()
        {
            return "Didi"; 
        }

        public override bool IsPeselValid(string pesel)
        {
           _peselList = GeTNumber(pesel);
           CutOffDate(pesel);
           return Checksum(pesel); 
        }

        public bool IsDataValid(int year, int month, int day)
        {
            return ValidateDate(year, month, day);
        }

        private List<string> GeTNumber(string pesel)
        {
            _peselList = new List<string>();

            foreach (var item in pesel)
            {
                _peselList.Add(item.ToString());
            }
            return _peselList; 
        }

        private bool Check(string pesel)
        {
            return pesel.ToCharArray().Count() == 11; 
        }
    }
}
