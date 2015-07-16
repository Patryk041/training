using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace FTPClient
{
    internal class GetFile //: FileOperation
    {
        public string Get(string sourcefilepath, string login, string pass)
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
                System.IO.File.WriteAllText(@"Bufor.txt", wiad);
                return wiad;
            }
            else
            {
                response.Close();

                return "chuja xD";
            }



        }

        /* public override string GetFileContent(string path)
         {
             return path;
         }*/
    }
}
