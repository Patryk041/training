using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;
using InitialTrainingLibrary.TrainingThree.Xml.Entities;

namespace InitialTrainingLibrary.TrainingThree.Xml.Logic
{
    public class XmlParser<T>
    {
        public T GetXmlData(string path)
        {
            using (StreamReader str = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(str);
            }
        }
    }
}
