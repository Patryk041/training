using System;
using System.Collections.Generic;
using Toci.Hornets.Sieradz.Duch;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator
{
    public static class StringComparatorsFactory
    {
        public static Dictionary<string, Func<string, string, bool>> ComparatorsFactory = new Dictionary<string, Func<string, string, bool>>()
         {
             {"Dummy", new DummyStringComparator().CompareTwoStrings},
           //  {"TypowyAdamMultitask", new MultiTypicalStringComparator().CompareTwoStrings},
             {"TypowyAdam", new SimpleTypicalStringComparator().CompareTwoStrings},
             {"UCantTouchThis", new UCantTouchThisStringComparator().CompareTwoStrings},
             {"UCTT_Autism", new UCTT_AutismStringComparator().CompareTwoStrings},
             {"Duch", new DuchStringComparator().CompareTwoStrings}

         };
    }
}