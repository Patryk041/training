using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingThree.Tpl;

namespace Toci.BeginnersTest.TrainingThree.TplWarrior
{
    [TestClass]
    public class WarriorTplXml
    {
        [TestMethod]
        public void TestXmlTpl()
        {
            //GetAllParsedDealersCars

            var showdown = new TplShowdown();


            for (int i = 0; i < 10; i++)
            {


                var result = showdown.GetAllParsedDealersCars(
                    @"D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingThree\Xml\data\");

                var test = result.Count;
            }


            //Assert.AreEqual(result.Count, 14092);
        }
    }
}
