using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Sieradz.Undergroun1Task.Interface
{
    interface IStringComparator
    {
        bool CompareTwoStrings(string s1, string s2);
        //dostajemy dwa stringi, sprawdzamy czy ich dlugosc (tylko liczba liter a-z) jest taka sama
        //Robimy oczywiscie UnitTesty ;)
    }
}
