using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Interfaces;
using Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.Entities;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonsUniversalFileParser.FileParsers
{
    public class XmlFileParser : FileParser
    {
        public override List<IParsable> GetParsedData(string filePath)
        {
            List<IParsable> parsedContent = new List<IParsable>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            foreach(XmlNode node in doc.DocumentElement)
            {
                string name = node["name"].InnerText;
                string surname = node["surname"].InnerText;
                DateTime date = DateTime.Parse(node["date"].InnerText);
                string account = node["account"].InnerText;
                string title = node["title"].InnerText;
                float money = float.Parse(node["money"].InnerText);
                parsedContent.Add(new XmlFileEntity(name, surname, date, account, title, money));
            }
            return parsedContent;
            /*
            
            XmlFileEntities entities;
            using(StreamReader read = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XmlFileEntities));
                entities = (XmlFileEntities)serializer.Deserialize(read);
            }
            
            return parsedContent;*/
        }
    }
}
