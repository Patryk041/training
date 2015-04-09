using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    public class RarFormat : PackFormats
    {
        public override string Unpack(string filePath, string extractPath)
        {
            _fileNames = new List<string> { "aaa.bmp" };
            return extractPath;
        }
    }
}
