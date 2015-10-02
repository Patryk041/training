using System;
using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.SemiRafista.KIR
{
    public class SeRaFileOperation : FileOperation
    {
        public override string GetFileContent(string path)
        {
            string text;
            try
            {
                StreamReader reader = new StreamReader(path);
                text = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                return null;
            }

            return text;
        }
    }
}