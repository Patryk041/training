using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public abstract class FileParser<THeader, TDetails, TFooter> : IDisposable where THeader : IFileSection where TDetails : IFileSection where TFooter : IFileSection
    {
        protected string FileName;

        protected FileParser(string fileName)
        {
            FileName = fileName;
        }

        protected abstract FileEntityBase ReadRow();

        public FileEntityBase GetParsedData(string line)
        {
            // TODO
            //TDetails details = new TDetails();
            //details.ReadEntry(line);

            return null;
        }

        public abstract string GetName();

        public abstract void Dispose();
    }
}
