using System.IO;
using System.Xml.Serialization;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Developers.RS.XmlParser
{
    public class RsXmlParser<T> : IFileParser
    {
        public T GetXmlData(string path)
        {
            using (var sr = new StreamReader(path))
            {
                var xmlSerializer = new XmlSerializer(typeof (T));
                return (T) xmlSerializer.Deserialize(sr);
            }
        }
    }
}
