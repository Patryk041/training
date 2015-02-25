using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InitialTrainingLibrary.syf.fileoperations.xml.logic
{
    class DataXmlParser
    {
        private string _path;

        public DataXmlParser(string path)
        {
            _path = path;
        }

        public XElement Read()
        {
            StreamReader str = new StreamReader(_path);
            string xml = str.ReadToEnd();

            return XElement.Parse(xml);
        }
    }
}
