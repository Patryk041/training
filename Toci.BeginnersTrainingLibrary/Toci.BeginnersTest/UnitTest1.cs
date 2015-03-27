using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq;

namespace Toci.BeginnersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDysqForBeginners()
        {
            Team test = new Team("Odra Opole");

            var team = test.CreateTeam();

            var name = test.GetTeamName();

            
        }
    }
}
