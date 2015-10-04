using System;
using System.IO;
using System.Net;

namespace Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank
{
    public class DownloadFile
    {
        public bool Download(string infoFile)
        {
            if (!Directory.Exists("download"))
            {
                try
                {
                    Directory.CreateDirectory("download");
                }
                catch (Exception)
                {
                    return false;
                }
                
            }

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(infoFile, @"download\" + Path.GetFileName(infoFile));
                }
                catch (Exception)
                {
                    return false;
                }
                

            }
            return true;
        }

    }

}