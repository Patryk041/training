using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingFour.Reflection.Training;
using InitialTrainingLibrary.warrior.EnumerableImplementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior.TrainingFour
{
    [TestClass]
    public class CustomGenericEnumerableTest
    {
        [TestMethod]
        public void CustomGenericEnumerableTestMethod()
        {
            CustomGenericEnumerable<Kobieta> customGenericEnumerable = new CustomGenericEnumerable<Kobieta>();

            foreach (var item in customGenericEnumerable)
            {
                //var test = item.RodzajUsmiechu;
            }
        }
    }
}
