using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Streams
{
    public abstract class TransferFileParser
    {
        public List<TransferEntity> OpenFile(string filePath)
        {
            //FileStream str = new FileStream();
            StreamReader reader = new StreamReader(filePath);
            var result = new List<TransferEntity>();

            while (!reader.EndOfStream)
            {
                result.Add(GetRow(reader.ReadLine()));
            }

            //Directory.GetFiles("")

            return result;
        }

        protected abstract TransferEntity GetRow(string row);
    }
}
