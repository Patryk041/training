using System;
using System.IO;
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
            return content;

        }
    }
}