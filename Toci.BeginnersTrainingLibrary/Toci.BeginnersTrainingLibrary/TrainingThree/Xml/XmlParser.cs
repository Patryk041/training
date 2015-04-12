using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Xml
{
    public class XmlParser
    {
        //XmlSerializer
        public T Deserialize<T>(string path)
            //D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingThree\Xml\data\garage.xml
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var file = new FileStream(path, FileMode.Open))
            {
                return (T)serializer.Deserialize(file);
            }

            //serializer.Serialize('asdres do plik', gasraz);
        }
    }
}
