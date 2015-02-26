using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.fileoperations.xml.entities;
using InitialTrainingLibrary.syf.fileoperations.xml.logic;

namespace InitialTrainingLibrary.syf.fileoperations.xmltpl.logic
{
    public class ParalelXmlParser
    {
        private string path = @"I:\self\trainings\Dropbox\szkolenie\v 2.0\code\InitialTrainingLibrary\InitialTrainingLibrary\syf\fileoperations\xmltpl\data\";

        public void ParseManyFiles()
        {
            IEnumerable<string> paths = Directory.GetFiles(path);

            paths.AsParallel().WithDegreeOfParallelism(10).ForAll(ParseIndividualFile);
        }

        private void ParseIndividualFile(string file)
        {
            DataXmlParser dataParser = new DataXmlParser(file);
            XmlParser parser = new XmlParser();
            var result = parser.Deserialise<Garage>(dataParser.Read());
        }
    }
}
