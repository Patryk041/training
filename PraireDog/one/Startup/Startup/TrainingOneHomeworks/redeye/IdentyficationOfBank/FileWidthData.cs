using System.IO;
using Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank.Interfaces;

namespace Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank
{
    public class FileWidthData :IGetFile
    {
        public FileInfo GetFile(string path) //http://www.nbp.pl/banki_w_polsce/ewidencja/dz_bank_jorg.txt
        {
            string fileName = Path.GetFileName(path);
            FileInfo fi = new FileInfo(@"download/"+fileName);

            bool fileExist; //= Directory.Exists("download") && File.Exists("download/myfile.txt");
            fileExist = fi.Exists;

            if (!fileExist)
            {
                DownloadFile dw = new DownloadFile();
                fileExist = dw.Download(path);
            }

            return fi;
        }
    }
}