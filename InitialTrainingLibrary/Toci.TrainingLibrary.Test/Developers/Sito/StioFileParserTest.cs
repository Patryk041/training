using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Sito.FileParser;
namespace Toci.TrainingLibrary.Test.Developers.Sito
{
    [TestClass]
   public class StioFileParserTest
    {
        [TestMethod]
        public void TestDysqFileParser()
        {
            var test =new  SitoDetailsParser();







            string filePath = @"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-01_321434535_sito.txt";
            

            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                    lines.Add(reader.ReadLine());

            }
            List<FileEntityBase> entities = lines.Select(line => test.ReadEntry(line)).ToList();
        }
    }
}
 