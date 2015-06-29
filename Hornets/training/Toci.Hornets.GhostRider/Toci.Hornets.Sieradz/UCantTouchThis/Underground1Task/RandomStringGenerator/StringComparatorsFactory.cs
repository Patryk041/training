using System;
using System.Collections.Generic;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task.RandomStringGenerator
{
    public static class StringComparatorsFactory
    {
        public static Dictionary<string, Func<string, string, bool>> ComparatorsFactory = new Dictionary<string, Func<string, string, bool>>()
         {
             {"Dummy", new DummyStringComparator().CompareTwoStrings},
             {"UCantTouchThis", new UCantTouchThisStringComparator().CompareTwoStrings},
             {"TypowyAdam", new UndergroundTask1().CompareTwoStrings}
         };
    }
}