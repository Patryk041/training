using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.RandomStringGenerator;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class StringComparatorsBenchmarks
    {
        private const string Pattern = "{0} time: {1} ms";
        private const int NumberOfRandomStringPairs = 1000;
        private const int LengthOfRandomString = 32;


        [TestMethod]
        public void UCTTStringComparatorsBenchmark()
        {
            List<string[]> stringsToCompare = UCTT_RandomStingGenerator.GenerateRandomStringPaitList(NumberOfRandomStringPairs, LengthOfRandomString);

            foreach (var item in StringComparatorsFactory.ComparatorsFactory)
            {
                var measuredTime = MeasureComparisionTime(stringsToCompare, item.Value);
                Debug.WriteLine(Pattern, item.Key, measuredTime);
            } 
        }

        private long MeasureComparisionTime(List<string[]> testList, Func<string,string, bool> comparatorFunc)
        {
            var timer = new Stopwatch();
            timer.Start();

            foreach (var item in testList)
                comparatorFunc(item[0], item[1]);

            timer.Stop();
            return timer.ElapsedMilliseconds;
        }
         
    }
}