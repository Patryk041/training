using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public class ParallelFileParser<TSaver> where TSaver : IDbSave
    {
        protected List<FileParser<IFileSection, IFileSection, IFileSection>> parsers = new List<FileParser<IFileSection, IFileSection, IFileSection>>(); 


    }
}
