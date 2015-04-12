using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingThree.Xml;
using Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities;

namespace Toci.BeginnersTest.TrainingThree.Xml
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void TestXmlParse()
        {
            var parser = new XmlParser();

            var result = parser.Deserialize<Garage>(
                @"D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingThree\Xml\data\garage.xml");
        }
    }
}
