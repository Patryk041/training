using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingThree.Tpl;
using Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities;

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

            Stopwatch stw = new Stopwatch();

            stw.Start();
            //Stopwatch.StartNew();
            var result = new List<Garage>();
            //for (int i = 0; i < 10; i++)
            {


                result = showdown.GetAllParsedDealersCars(
                    @"D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingThree\Xml\data\",
                    4);

                var test = result.Count;
            }

            var timeElapsed = stw.Elapsed;
            Debug.WriteLine("Zeszlo czasu: {0}", timeElapsed);
            stw.Stop();
            Debug.WriteLine("Num of procs: {0}", Environment.ProcessorCount);

            Assert.AreEqual(result.Count, 10768);
        }
    }
}
