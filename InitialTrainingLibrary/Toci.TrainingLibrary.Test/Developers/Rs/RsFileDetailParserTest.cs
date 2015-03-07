using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.RS.FileParser;

namespace Toci.TrainingLibrary.Test.Developers.Rs
{
    [TestClass]
    public class RsFileDetailParserTest
    {
        [TestMethod]
        public void TestRsJsonFile()
        {
            var parser = new RsFileDetailsParser();


            List<string> lines = new List<string>()
            {
                "{\"name\": \"Roman\",\"surname\": \"Suska\",\"datetime\": \"2015-03-05\",\"number\": \"1234567890\"}",
            };

            foreach (var line in lines)
            {
                var dsqf= parser.ReadEntry(line);
            }
            
        }
    }
}
