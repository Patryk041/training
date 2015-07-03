using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.RandomStringGenerator;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.StringComparator;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class StringComparatorsBenchmarks
    {
        private const string Pattern = "{0} time: {1} ms";


        [TestMethod]
        public void StringComparatorsBenchmark()
        {
            List<string[]> stringsToCompare = UCTT_RandomStingGenerator.GenerateRandomStringPaitList(1000000, 32);

            foreach (var item in StringComparatorsFactory.ComparatorsFactory)
            {
                var measuredTime = MeasureComparisionTime(stringsToCompare, item.Value);
                Debug.WriteLine(Pattern, item.Key, measuredTime);
            }
            //breakpointa można dać też na "}" i zadziała a nie będzie warninga 
        }

        private long MeasureComparisionTime(List<string[]> testList, Func<string,string, bool> comparatorFunc)
        {
            var timer = new Stopwatch();
            timer.Start();

            foreach (var item in testList)
            {
                comparatorFunc(item[0], item[1]);
            }

            timer.Stop();

            return timer.ElapsedMilliseconds;
        }
         
    }
}