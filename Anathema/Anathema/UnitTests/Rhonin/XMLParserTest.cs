using System;
using Anathema.Rhonin.TrainingThree.XML;
using Anathema.Rhonin.TrainingThree.XML.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rhonin
{
    [TestClass]
    public class XmlParserTest
    {
        [TestMethod]
        public void TestXmlParser()
        {
            var parser = new XmlParser();
            var result = parser.Deserialize<Garage>(
                @"C:\Users\michal\Documents\training\Anathema\Anathema\Anathema\Rhonin\TrainingThree\XML\XMLFiles\garage.xml");

        }
    }
}
