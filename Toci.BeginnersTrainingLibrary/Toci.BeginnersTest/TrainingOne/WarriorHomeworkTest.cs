using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Delegates;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;
using Toci.BeginnersTrainingLibrary.TrainingOne.Warrior;

namespace Toci.BeginnersTest.TrainingOne
{
    [TestClass]
    public class WarriorHomeworkTest
    {
        [TestMethod]
        public void TestHomework()
        {
            List<IDateValidator> homeworksList = new List<IDateValidator>
            {
                new WarriorDateValidator(),

            };

            DelegatesShowdown showdown = new DelegatesShowdown();
            showdown.test();

            //Debug.WriteLine();
        }
    }
}
