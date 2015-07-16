using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.mBank
{
    public class TypowyAdamBankTransfersParser : BankTransfersParser
    {
#pragma warning disable 618
        protected XmlDocument myString= new XmlDataDocument();
#pragma warning restore 618
        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new SieradzFileOperation();
         
            List<BankTransfer> mBankTransferList = new List<BankTransfer>();
            myString.LoadXml(BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + @"mBankTransfers.xml"));
            foreach (var childNode in myString.DocumentElement.ChildNodes)
            {
               // GetTransferEntry(myString.GetElementsByTagName(childNode.).Item(0).InnerXml);
            }
                
            return mBankTransferList;

        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var mBankTransfer = new SieradzBankTransfer();
            
            //TODO it's possible to reduce that sphagetti?
            mBankTransfer.SourceBank = "";
            mBankTransfer.DestinationBank = "";
            mBankTransfer.TransferInfo.Amount = "";
            mBankTransfer.TransferInfo.DestinationAccountNumber = "";
            mBankTransfer.TransferInfo.DestinationPersonName = "";
            mBankTransfer.TransferInfo.SourceAccountNumber = "";
            mBankTransfer.TransferInfo.TransferDate = "";
            mBankTransfer.TransferInfo.TransferTitle = "";
            return mBankTransfer;

        }
    }
}