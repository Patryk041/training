using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    public abstract class FilesFormat
    {
        private List<string> _fileNames;

        public virtual void FileProcessing(string extractPath)
        {
            _fileNames = SetFileNames();

            //do stuff
        }

        public abstract List<string> SetFileNames();

        public abstract void OpenFile(string filePath);

        public abstract void SaveFile(string filePath, string fileName);
    }
}
