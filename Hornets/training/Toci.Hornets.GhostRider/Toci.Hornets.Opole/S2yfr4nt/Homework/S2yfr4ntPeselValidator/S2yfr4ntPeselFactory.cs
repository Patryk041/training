using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntPeselValidator
{
    public class S2yfr4ntPeselFactory : S2yfr4ntGenericFactory<List<int>, Func<int, int, List<int>>>
    {
        private const int DECIMAL_PART_OF_MONTH = 10;


        public S2yfr4ntPeselFactory()
        {
            FactoryDictionary = new Dictionary<List<int>, Func<int, int, List<int>>>
            {
                {new List<int>() {0, 1}, (m, y)=>new List<int>(){m, y+1900}},
                {new List<int>() {2, 3}, (m, y)=>new List<int>(){m-20, y+2000}},
                {new List<int>() {4, 5}, (m, y)=>new List<int>(){m-40, y+2100}},
                {new List<int>() {6, 7}, (m, y)=>new List<int>(){m-60, y+2200}},
                {new List<int>() {8, 9}, (m, y)=>new List<int>(){m-80, y+1800}},
            };

        }

        public List<int> GetMonthYearList(int month, int year)
        {
            var key = FactoryDictionary.Keys.FirstOrDefault(x => x.Contains((month / DECIMAL_PART_OF_MONTH)));
            return FactoryDictionary[key].Invoke(month, year);
        }
    }
}