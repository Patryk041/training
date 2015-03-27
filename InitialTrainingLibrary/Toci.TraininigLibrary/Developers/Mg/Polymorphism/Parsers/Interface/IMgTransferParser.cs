using System.Collections.Generic;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers.Interface
{
    public interface IMgTransferParser
    {
        List<FileEntityBase> GetEntityTransfersList(string filePath);
    }
}
