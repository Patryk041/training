using System;
using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.ProjectElixir
{
    public class FileOperationsWroclaw : FileOperation
    {
        public override string GetFileContent(string path)
        {
            var fileExtension = path.Substring(path.Length - 3);

            switch (fileExtension)
            {
                case ("txt"):
                    return ReadTxtFile(path);


                default:
                    throw new Exception("Error file extension uknown");
            }
        }

        private string ReadTxtFile(string path)
        {
            try
            {
                using (var sr = new StreamReader(path))
                {
                    var fileContent = sr.ReadToEnd();

                    return fileContent;
                }
            }
            catch (Exception e)
            {
                throw new Exception("File not found!");
            }
        }
    }
}