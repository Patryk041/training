using System.IO;
using Startup.redeye.IdentyficationOfBank.Interfaces;

namespace Startup.redeye.IdentyficationOfBank
{
    public class FileWidthData :IGetFile
    {
        public FileInfo GetFile()
        {
            FileInfo fi = new FileInfo("download/myfile.txt");

            bool fileExist; //= Directory.Exists("download") && File.Exists("download/myfile.txt");
            fileExist = fi.Exists;

            if (!fileExist)
            {
                DownloadFile dw = new DownloadFile();
                fileExist = dw.Download("http://www.nbp.pl/banki_w_polsce/ewidencja/dz_bank_jorg.txt");
            }

            return fi;
        }
    }
}