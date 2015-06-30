using System;
using System.Collections.Generic;
using Toci.Hornets.Sieradz.Duch;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task
{
    public static class StringComparatorsFactory
    {
        public static Dictionary<string, Func<string, string, bool>> ComparatorsFactory = new Dictionary<string, Func<string, string, bool>>()
         {
             {"Dummy", new DummyStringComparator().CompareTwoStrings},
             {"TypowyAdam", new UndergroundTask1().CompareTwoStrings},
             {"UCantTouchThis", new UCantTouchThisStringComparator().CompareTwoStrings},
             {"UCTT_Autism", new UCTT_AutismStringComparator().CompareTwoStrings},
             {"Duch", new DuchStringComparator().CompareTwoStrings}
            //,{"TypowyAdamMultitask", new ExtraStringParser().CompareTwoStrings}

         };
    }
}