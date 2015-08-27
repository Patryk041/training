﻿using InitialTrainingLibrary.syf.fileoperations.xml.logic;
using InitialTrainingLibrary.syf.fileoperations.xmltpl.logic;
using InitialTrainingLibrary.syf.proofsofconcept.async;
using InitialTrainingLibrary.syf.proofsofconcept.clone;
using InitialTrainingLibrary.syf.proofsofconcept.dispose;
using InitialTrainingLibrary.TrainingFour.Reflection.Training;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.warrior
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]
        public void RamExhaustTest()
        {
            var ramExhauster = new RamExhauster();

            ramExhauster.ExhaustRam();

            ramExhauster.Wait();
        }

        [TestMethod]
        public void TestCloneBehaviour()
        {
            ExampleTypeUsage usage = new ExampleTypeUsage();

            usage.TestClone();
        }

        [TestMethod]
        public void XmlParseTest()
        {
            XmlParseLogic logic = new XmlParseLogic();

            var result = logic.ParseData();

            ParalelXmlParser paralelParser = new ParalelXmlParser();

            paralelParser.ParseManyFiles();
        }

        [TestMethod]
        public void AsyncTest()
        {
            OldStyle old = new OldStyle();

            old.test();

            NewStyle ns = new NewStyle();

            ns.test();
        }

        [TestMethod]
        public void ReflectionTests()
        {
            ReflectKobieta reflect = new ReflectKobieta();
            reflect.tests();
        }
    }
}