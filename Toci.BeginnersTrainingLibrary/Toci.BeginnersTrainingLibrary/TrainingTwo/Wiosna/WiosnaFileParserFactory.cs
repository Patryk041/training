using System;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Matwie;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;



namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Wiosna
{
    public class WiosnaFileParserFactory 
    {
        public static TransferFileParser GetParsedItems(string filepath)
        {
            if (filepath.Contains("ing.txt"))
            {
                return new WiosnaFileParserING();
            }
            else if (filepath.Contains("multibank.txt"))
            {
                return new WiosnaFileParserMultiBank();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
