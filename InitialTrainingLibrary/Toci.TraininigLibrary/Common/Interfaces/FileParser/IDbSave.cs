
using Toci.Db.Interfaces;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Common.Interfaces.FileParser
{
    public interface IDbSave
    {
        bool Save(FileEntityBase entry, IModel dataBaseModel);
    }
}
