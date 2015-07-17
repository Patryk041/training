using System;
using System.Collections.Generic;
using System.Xml;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils;


namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.mBank
{
    public class TypowyAdamBankTransfersParser : BankTransfersParser
    {

        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new SieradzFileOperation();
#pragma warning disable 618
            XmlDocument xmlFile= new XmlDataDocument();
#pragma warning restore 618
            List<BankTransfer> mBankTransferList = new List<BankTransfer>();
            xmlFile.LoadXml(BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + @"mBankTransfers.xml"));
            foreach (var childNode in xmlFile.DocumentElement.ChildNodes)
            {
                mBankTransferList.Add(GetTransferEntry(xmlFile.GetElementsByTagName((string) childNode.GetType().GetProperty("Name").GetValue(childNode)).Item(0).OuterXml)); 
            }
                
            return mBankTransferList;

        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var mBankTransfer = new SieradzBankTransfer();
#pragma warning disable 618
            XmlDocument xmlNode = new XmlDataDocument();
#pragma warning restore 618
            string datePattern = "d.m.yyyy";
            DateTime currentDate = DateTime.Now;
            var bankDictionary = SieradzBankTransfersUtils.Instance;

            xmlNode.LoadXml(entry);
            //TODO it's possible to reduce that sphagetti?
            // IT FCKIN IS!         @UCTT
            mBankTransfer.TransferInfo.Amount = xmlNode.GetElementsByTagName("Amount").Item(0).InnerText;
            mBankTransfer.TransferInfo.DestinationAccountNumber = xmlNode.GetElementsByTagName("DestinationAccountNumber").Item(0).InnerText;
            mBankTransfer.TransferInfo.DestinationPersonName = xmlNode.GetElementsByTagName("DestinationPersonName").Item(0).InnerText;
            mBankTransfer.TransferInfo.SourceAccountNumber = xmlNode.GetElementsByTagName("SourceAccountNumber").Item(0).InnerText;
            mBankTransfer.TransferInfo.TransferDate = currentDate.ToString(datePattern);
            mBankTransfer.TransferInfo.TransferTitle = xmlNode.GetElementsByTagName("TransferTitle").Item(0).InnerText;
            mBankTransfer.SourceBank = bankDictionary.GetBankName(mBankTransfer.TransferInfo.SourceAccountNumber.Substring(2, 4));
            mBankTransfer.DestinationBank = bankDictionary.GetBankName(mBankTransfer.TransferInfo.DestinationAccountNumber.Substring(2, 4));
            return mBankTransfer;

        }
    }
}