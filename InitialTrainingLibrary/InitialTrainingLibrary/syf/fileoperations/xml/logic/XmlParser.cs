using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace InitialTrainingLibrary.syf.fileoperations.xml.logic
{
    class XmlParser
    {
        public virtual T Deserialise<T>(XElement contentsValue)
        {
            var selializer = new XmlSerializer(typeof(T));

            using (var reader = new StringReader(contentsValue.ToString()))
            {
                return (T)selializer.Deserialize(reader);
            }
        }
    }
}
