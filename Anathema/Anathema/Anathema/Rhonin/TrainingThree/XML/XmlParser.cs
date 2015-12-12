using System.IO;
using System.Xml.Serialization;
using Anathema.Rhonin.TrainingThree.XML.Entities;

namespace Anathema.Rhonin.TrainingThree.XML
{
    public class XmlParser
    {
        public T Deserialize<T>(string path)
        {
            //var serializer = new XmlSerializer(typeof(T));
            var serializer = new XmlSerializer(typeof(Garage));
            return (T)serializer.Deserialize(new FileStream(path, FileMode.Open));
        }
    }
}