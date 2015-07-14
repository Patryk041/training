using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public abstract class SieradzBankTransfersParser : BankTransfersParser
    {
        public override List<BankTransfer> GetBankTransfers()
        {
            throw new System.NotImplementedException();
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            throw new System.NotImplementedException();
        }

        protected virtual Dictionary<string, string> GetBankNamesDictionary()
        {
            var bankNamesDictionary = new Dictionary<string, string>();

            foreach (var line in File.ReadAllLines(SieradzBankFilesPathHolder.configPath))
            {
                var splitedLine = line.Split(' ');
                if(splitedLine[0].Length != 4) continue;
                bankNamesDictionary.Add(splitedLine.First(), splitedLine.Last());
            }
            return bankNamesDictionary;
            //stestowane i zwraca co potrzeba
        }
    }
}