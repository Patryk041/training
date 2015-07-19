using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.TypowyAdam.GenericListTaskTrainingFour;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class TypowyAdamGenericListTest
    {
        [TestMethod]
        public void TestGenericList()
        {
            var testGenericList = new TypowyAdamGenericList<int>();
            testGenericList.Add(5);
            testGenericList.Add(4);
            testGenericList.Add(3);
            testGenericList.Add(2);
            testGenericList.Add(1);
            Assert.AreEqual(testGenericList.GetArrayLenght(), 5);
            Assert.AreEqual(testGenericList.GetAllItems().ToList().Sum(), 15);
            testGenericList.Remove(1);
            Assert.AreEqual(testGenericList.GetArrayLenght(), 4);
            Assert.AreEqual(testGenericList.GetAllItems().ToList().Sum(), 14);
            
        }

        
    }
}
