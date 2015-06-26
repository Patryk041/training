using System.Collections.Generic;
using System.IO;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ksebal
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
                string res = reader.ReadLine();
                result.Add(GetRow(res));
            }

            //Directory.GetFiles("")

            return result;
        }

        public abstract TransferEntity GetRow(string row);
    }
}
