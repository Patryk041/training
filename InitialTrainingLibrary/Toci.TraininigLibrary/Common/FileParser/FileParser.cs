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

        //protected abstract IEnumerable<FileEntityBase> GetParsedData();

        public IEnumerable<FileEntityBase> GetParsedData()
        {
            // TODO
            return null;
        }

        public abstract string GetName();

        public abstract void Dispose();
    }
}
