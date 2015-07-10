using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Gliwice.Didi.PeselTask
{
    public static class DataFactory
    {
        private static Dictionary<int, Func<IData>> _dataDictionary = new Dictionary<int, Func<IData>>()
        {
             {1, () => new YearClass()}
            ,{2, () => new MonthClass()}
            ,{3, () => new DataClass()}
        };

        private static void ValidateDataParser(int key, Func<IData> value) 
        {
            
        }
    }
}
