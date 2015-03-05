using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Hipek.FileParser;

namespace Toci.TrainingLibrary.Test.Developers.Hipek
{
    [TestClass]
    public class HipekFileParserTest
    {
        [TestMethod]
        public void HipekFileParserMethod()
        {
            string fileName = @"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-02_7777777_hipek.txt";

            HipekFileParser fileParser = new HipekFileParser();

            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }
            }

            List<FileEntityBase> entityBases = new List<FileEntityBase>();

            foreach (var line in lines)
            {
                entityBases.Add(fileParser.GetParsedData(line));
            }

            Assert.AreEqual(entityBases[5].Name, "Zbychu");
            Assert.AreEqual(entityBases[5].Surname, "Kowalski");
            Assert.AreEqual(entityBases[5].Date.ToString(), "2015-03-02 00:00:00");
            Assert.AreEqual(entityBases[5].Account, "123123123");

        }
    }
}
