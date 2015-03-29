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
        public void OpenFile(string filePath)
        {
            //FileStream str = new FileStream();
            StreamReader reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                GetRow(reader.ReadLine());
            }

            //Directory.GetFiles("")
        }

        protected abstract TransferEntity GetRow(string row);
    }
}
