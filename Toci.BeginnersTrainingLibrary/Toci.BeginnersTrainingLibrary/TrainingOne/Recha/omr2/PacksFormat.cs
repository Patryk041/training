using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    public abstract class PackFormats
    {
        protected List<string> _fileNames;

        public virtual string DownloadPack(string ulrPath, string downloadPath)
        {
            //download logic

            return downloadPath;
        }

        public List<string> GetFileNames()
        {
            return _fileNames;
        }

        public abstract string Unpack(string filePath, string extractPath);
    }
}
