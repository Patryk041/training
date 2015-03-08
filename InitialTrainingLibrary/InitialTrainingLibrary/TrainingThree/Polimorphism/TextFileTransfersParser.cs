using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace InitialTrainingLibrary.TrainingThree.Polimorphism
{
    public class TextFileTransfersParser : TransfersParserBase
    {
        private const string delimiter = "|";

        public override List<FileEntityBase> GetTransfers(string path)
        {
            using (StreamReader str = new StreamReader(path))
            {
                var result = new List<FileEntityBase>();

                while (!str.EndOfStream)
                {
                
                    var line = str.ReadLine();

                    var chunks = line.Split(new[] {delimiter}, StringSplitOptions.None);

                    result.Add(new FileEntityBase() { Account = chunks[3], Date = Convert.ToDateTime(chunks[2]), Name = chunks[0], Surname = chunks[1]});
                }

                return result;
            }
        }
    }
}
