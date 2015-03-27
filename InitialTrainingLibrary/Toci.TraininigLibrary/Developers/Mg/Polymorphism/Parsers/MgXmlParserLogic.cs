using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers
{
    class MgXmlParserLogic<T>
    {

        public T GetXmlData(ref string path)
        {
            using (StreamReader str = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(str);
            }
        }
    }
}
