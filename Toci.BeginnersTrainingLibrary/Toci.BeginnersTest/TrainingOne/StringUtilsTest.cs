using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Warrior;

namespace Toci.BeginnersTest.TrainingOne
{
    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void TestTextUtilPalindrom()
        {
            Assert.IsTrue(TextUtils.IsPalindrom("radar"));
            Assert.IsFalse(TextUtils.IsPalindrom("dhsafds"));
        }

        [TestMethod]
        public void TestPalindromsSet()
        {
            FilterSets sets = new FilterSets();
            var result = sets.GetPalindroms(new[] {"radar", "fdsabhfda", "cyc", "fxafdagdsgsdf", "agga" });

            Assert.AreEqual(result.Length, 3);
        }
    }
}
