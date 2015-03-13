using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers
{
    public interface IMgTransferParser
    {
        List<FileEntityBase> GetEntityTransfersList(string filePath);
    }
}
