using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingThree.LINQ
{
    [TestClass]
    public class AsParallelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var entires = new List<int>()
            {
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
                32434,43,24323,423,4,2334,32,423,43,324,23,4,21321,321,2313,123,132,
            }.ToArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 20000; i++)
            {
                var result = entires.AsParallel().Where(item => item > 3200 && item < 5000).Select(GetIntWrapper).ToList();
            }
            stopwatch.Stop();

            //LINQ PLINQ //100 10000000000

            var milliseconds = stopwatch.ElapsedMilliseconds;

        }

        private IntWrapper GetIntWrapper(int entry)
        {
            return new IntWrapper()
            {
                result = entry
            };
        }


    }


    class IntWrapper
    {
        public int result { get; set; }
    }
}
