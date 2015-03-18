using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Web.Training.Primary.Models.Mg;

namespace Toci.TrainingLibrary.Test.Developers.Mg.Reflection
{
    [TestClass]
    public class WarriorMgControllerReflectionTest
    {
        [TestMethod]
        public void MgWarriorTestController()
        {
            MgFillReflecionModel fillReflecionModel = new MgFillReflecionModel(new Dictionary<string, string>()
            {
                {"NUMBER","dsadf"},
                {"NAME", "fdsagfds"},
                {"SURNAME", "gdsfghfds"},
                {"DESCRIPTION", "rewfdsf"},
                {"CAR","rewfdgds"}

            });



            fillReflecionModel.GetFilledMgReflectionModelModel();
        }
    }

    
}
