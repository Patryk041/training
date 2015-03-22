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
        //protected string FileName;

        protected TDetails DetailsParser;

        protected FileEntityBase Row;

        protected FileParser(TDetails detailsParser)
        {
            //FileName = fileName;
            DetailsParser = detailsParser;
        }

        //protected abstract FileEntityBase ReadRow();

        public virtual FileEntityBase GetParsedData(string line)
        {
            // TODO
            //TDetails details = new TDetails();
            Row = DetailsParser.ReadEntry(line);


            return Row;
        }

        public abstract string GetName();

        public abstract void Dispose();
    }
}
