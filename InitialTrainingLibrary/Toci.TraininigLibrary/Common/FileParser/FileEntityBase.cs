using System;
using Toci.Db.Interfaces;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public class FileEntityBase : IDbSave
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Account { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Name, Surname, Date, Account);
        }

        public virtual string GetLine()
        {
            return string.Format("{0} {1} {2} {3}", Name, Surname, Date, Account);
        }

        public bool Save(FileEntityBase entry, IModel dataBaseModel)
        {
            throw new NotImplementedException();
        }
        
    }
}
