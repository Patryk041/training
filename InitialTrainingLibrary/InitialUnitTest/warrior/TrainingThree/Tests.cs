using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.fileoperations.xml.entities;
using InitialTrainingLibrary.TrainingFour.Reflection.PreTest;
using InitialTrainingLibrary.TrainingThree.Xml.Entities;
using InitialTrainingLibrary.TrainingThree.Xml.Logic;
using InitialUnitTest.szymon93;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior.TrainingThree
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestParseXml()
        {
            XmlParser<Garage> test = new XmlParser<Garage>();
            var garage = test.GetXmlData(@"I:\self\trainings\Dropbox\szkolenie\v 2.0\code\InitialTrainingLibrary\InitialTrainingLibrary\syf\fileoperations\xml\data\data.xml");


            XmlParser<Transfers> transferParser = new XmlParser<Transfers>();
            var result = transferParser.GetXmlData(@"I:\self\trainings\Dropbox\szkolenie\v 2.0\code\InitialTrainingLibrary\Toci.TraininigLibrary\xmldata\transfer_2015-03-07_43657284832_warrior.xml");
        }

        [TestMethod]
        public void TestReflection()
        {
            ReflectFlower reflectFlower = new ReflectFlower();

            reflectFlower.FillFlower();
        }
    }
}
