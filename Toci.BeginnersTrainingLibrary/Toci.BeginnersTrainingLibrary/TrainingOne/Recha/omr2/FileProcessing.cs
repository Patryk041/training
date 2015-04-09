namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    public abstract class FileProcessing<TPackFormat, TFileFormat>
        where TPackFormat : PackFormats
        where TFileFormat : IFilesFormat
    {
        private TPackFormat _packFormat;
        private TFileFormat _fileFormat;
        private string _urlPath;
        private string _filePath;
        private string _extractPath;
        private bool _download;

        protected FileProcessing(string path, TPackFormat packFormat, TFileFormat fileFormat, bool download)
        {
            _packFormat = packFormat;
            _fileFormat = fileFormat;
            _download = download;
            if (_download) _urlPath = path;
            else _filePath = path;
        }

        public void DownloadPack(string downloadPath)
        {
            _filePath = _packFormat.DownloadPack(_urlPath, downloadPath);
        }

        public void UnpackFiles(string extractPath)
        {
            _extractPath = _packFormat.Unpack(_filePath, extractPath);
        }

        public virtual void ReadFiles()
        {
            var fileNamesList = _packFormat.GetFileNames();

            foreach (var fileName in fileNamesList)
            {
                _fileFormat.FileProcessing(_extractPath + fileName);
            }
        }
    }
}
