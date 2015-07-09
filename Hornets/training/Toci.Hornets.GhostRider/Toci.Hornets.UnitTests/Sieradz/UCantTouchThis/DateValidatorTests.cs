using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class DateValidatorTests
    {
        [TestMethod]
        public void UCTTDateValidatorTest()
        {
            List<int[]> correctDatesList = new List<int[]>
            {
                new []{29, 2, 1816},
                new []{28, 2, 1815},
                new []{29, 2, 2160},
                new []{29, 2, 2224},
                new []{29, 2, 2008},
                new []{31, 12, 1802},
                new []{1, 1, 5555},
                new []{5, 5, 1855}
            };

            List<int[]> incorrectDatesList = new List<int[]>
            {
                new []{29, 2, 2223},
                new []{0, 4, 123},
                new []{22, 0, 12},
                new []{123, 3, 852},
                new []{-1, -1, -1},
            };

            var time = Stopwatch.StartNew();
            correctDatesList.ForEach(date => Assert.IsTrue(UCTT_PeselValidatorUtils.IsDateValid(date[0], date[1], date[2])));

            incorrectDatesList.ForEach(date => Assert.IsFalse(UCTT_PeselValidatorUtils.IsDateValid(date[0], date[1], date[2])));
            time.Stop();
            Debug.WriteLine("Time: " + time.ElapsedMilliseconds + " ms");
        }
         
    }
}