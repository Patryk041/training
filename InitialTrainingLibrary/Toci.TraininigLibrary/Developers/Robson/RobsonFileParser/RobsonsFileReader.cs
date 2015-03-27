using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toci.TraininigLibrary.Developers.Robson.RobsonFileParser
{
    public class RobsonsFileReader
    {
        public static IEnumerable<string> GetLine(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    yield return reader.ReadLine();
                }
            }        
        }
    }
}
