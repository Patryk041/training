namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    public abstract class FileProcessing<TPackFormat, TFileFormat>
        where TPackFormat : PackFormats
        where TFileFormat : FilesFormat
    {
        private TPackFormat _packFormat;
        private TFileFormat _fileFormat;
        private string _filePath;
        private string _extractPath;

        protected FileProcessing(string filePath, TPackFormat packFormat, TFileFormat fileFormat)
        {
            _packFormat = packFormat;
            _fileFormat = fileFormat;
            _filePath = filePath;
        }

        public string DownloadPack(string downloadPath)
        {
            return _packFormat.DownloadPack(_filePath, downloadPath); //url, download path
        }

        public string UnpackFiles(string extractPath)
        {
            return _packFormat.Unpack(_filePath, extractPath); //pack path, extract path
        }

        public virtual void ProcessingOnExtractedFiles()
        {
            _fileFormat.FileProcessing(_extractPath);
        }
    }
}
