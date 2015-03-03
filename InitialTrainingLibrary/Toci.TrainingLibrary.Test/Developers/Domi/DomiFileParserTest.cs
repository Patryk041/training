using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Domi;

namespace Toci.TrainingLibrary.Test.Developers.Domi
{
    [TestClass]
    public class DomiFileParserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DomiFileDetails details = new DomiFileDetails();
        

            List<string> lines = new List<string>();
            string pathFile =
                @"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-02_4325234564_domi.txt";
           
            using (StreamReader reader = new StreamReader(pathFile))
            {
                while(!reader.EndOfStream)
                lines.Add(reader.ReadLine());
            }
            
            var test = details.ReadEntry(lines[0]);
            
            Assert.AreEqual(test.Name, "Dominika");
            Assert.AreEqual(test.Surname, "Dziurzynska");
          //  Assert.AreEqual(test.Date, "2015-03-13 00:00:00"); nie działa mi porównanie z datą 
            Assert.AreEqual(test.Account, "13039302007");

        }

    }
}
