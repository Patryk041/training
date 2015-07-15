using System.Diagnostics.Eventing.Reader;
using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    public class filemikzeoperation : FileOperation
    {
        private FTPcs geter;
        
        public filemikzeoperation(FTPcs d)
        {
            geter = d;
        }

        public override string GetFileContent(string serverpath)
        {
            return geter.Get(serverpath);

        }
    }
}//ftp:://jakas.pl/banki/banki.txt

