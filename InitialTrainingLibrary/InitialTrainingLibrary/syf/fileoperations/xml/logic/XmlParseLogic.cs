using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.fileoperations.xml.entities;

namespace InitialTrainingLibrary.syf.fileoperations.xml.logic
{
    public class XmlParseLogic
    {
        private string path = @"I:\self\trainings\Dropbox\szkolenie\v 2.0\code\InitialTrainingLibrary\InitialTrainingLibrary\syf\fileoperations\xml\data\data.xml";

        public Garage ParseData()
        {
            DataXmlParser parser = new DataXmlParser(path);

            XmlParser genericXmlParser = new XmlParser();

            return genericXmlParser.Deserialise<Garage>(parser.Read());
        }
    }
}
