using System;
using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree.VnthPlay
{
    public class Coffee2FileOperation : FileOperation
    {
        protected string PathToLog = "..//..//Bytom//Coffee13//Log//FileLog.txt";

        public override string GetFileContent(string path)
        {
            var content = "";

            if (File.Exists(path))
            {
                using (var file = new StreamReader(path))
                {
                    content = file.ReadToEnd();
                }

            }
            SaveToLog(path,PathToLog);
            return content;

        }


        
        private  void SaveToLog(string pathToProcessedFile, string selectLogPath)
        {
            DateTime thisDate = DateTime.Now;
            using (var file = new StreamWriter(selectLogPath, true))
            {
                file.WriteLine("Date: "+ thisDate +" file loaded: "+ pathToProcessedFile);
            }
        }
    }
}