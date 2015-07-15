using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.Pekao
{
    public class DjBankTransfersParser : BankTransfersParser
    {
        public DjBankTransfersParser()
        {
            BankFileOperation = new SieradzFileOperation();
        }

        public override List<BankTransfer> GetBankTransfers()
        {
            var fileContent =
                BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + "Pekao.xml");

            var result = fileContent.Split('\n').Skip(1).Select(GetTransferEntry).Where(x => x != null).ToList();
            return result;
        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            BankTransfer transfer = new SieradzBankTransfer();
            try
            {
                using (var reader = new StringReader(entry))
                {
                    var serializer = new XmlSerializer(typeof(SieradzTransferInfo));
                    var transferInfo = (SieradzTransferInfo)serializer.Deserialize(reader);

                    transfer.SourceBank =
                        SieradzBankTransfersUtils.Instance.GetBankName(transferInfo.SourceAccountNumber.Substring(2,4));
                    transfer.DestinationBank =
                        SieradzBankTransfersUtils.Instance.GetBankName(transferInfo.DestinationAccountNumber.Substring(2, 4));
                }                
            }
            catch (Exception)
            {
                transfer = null;
            }

            return transfer;
        }
    }
}