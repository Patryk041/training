using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Logic
{
    public class AccountTranferParseSaveLogic
    {
        private ParallelFileParser<IDbSave> parallelFileParser;

        public AccountTranferParseSaveLogic()
        {
            parallelFileParser = new ParallelFileParser<IDbSave>(DoOperation);
        }

        private bool DoOperation(FileEntityBase fileEntity)
        {
            return true;
        }
    }
}
