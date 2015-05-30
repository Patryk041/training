using System;
using System.Collections.Generic;
using InitialTrainingLibrary.warrior.tpl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.TrainingLibrary.Test.Developers.Warrior.Tpl
{
    [TestClass]
    public class PalindromParallelTesterTest
    {
        [TestMethod]
        public void PalindromParallelTesterPalindromsTest()
        {
            PalindromParallelTester test = new PalindromParallelTester();

            List<string> palindromCandidates = new List<string>
            {
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fddswgfdgwd",
                "fgwgwh",
            };

            test.RunParallelProcessing(palindromCandidates);
        }
    }
}
