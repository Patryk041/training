using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Kielich;
using Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr;

namespace Toci.BeginnersTest
{
    /// <summary>
    /// Summary description for Robot
    /// </summary>
    [TestClass]
    public class TestRobot
    {
        [TestMethod]
        public void TestMethod()
        {
            var asimo = new Robot();

            asimo.SetConnection(true);
            asimo.SetWork(true);
            asimo.SetCapacity(50);
            asimo.SetVoltage(11);
            Assert.IsTrue(asimo.IsConnected());
            Assert.IsTrue(asimo.IsWorking());
            Assert.IsTrue(asimo.IsEnough());
            Assert.IsTrue(asimo.Damage(true));
            Assert.IsFalse(asimo.Record(false));
            Assert.IsTrue(asimo.Jump(true));
            Assert.IsFalse(asimo.Scan(false));
        }
    }
}
