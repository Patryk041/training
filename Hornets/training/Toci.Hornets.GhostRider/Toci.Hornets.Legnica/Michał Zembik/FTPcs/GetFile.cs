using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    internal class GetFile
    {
        public string Get(string sourcefilepath, string desinationfilepath, string login, string pass)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(sourcefilepath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(login, pass);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            if (responseStream != null)
            {
                StreamReader reader = new StreamReader(responseStream);
                byte[] info = Encoding.Default.GetBytes(reader.ReadToEnd());
                string wiad = Encoding.Default.GetString(info);
                reader.Close();
                response.Close();
                Console.Read();
                return wiad;
            }
            else
            {
                response.Close();
                Console.Read();
                return "chuja xD";
            }



        }
    }
}
