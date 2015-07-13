using System;
using System.IO;
using System.Text;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree
{
    public class CoffeeFileOperation : FileOperation
    {
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
            SaveToLog(path);
            return content;

        }


        //dodanie zapisu do logu ze pobrano plik ...
        private  void SaveToLog(string pathToProcessedFile)
        {
            using (var file = new StreamWriter(@"..\..\Bytom\Coffee13\Log\FileLog.txt", true))
            {
                file.WriteLine("file loaded: "+ pathToProcessedFile);
            }
        }
    }
}