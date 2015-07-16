using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.mBank
{
    public class TypowyAdamBankTransfersParser : BankTransfersParser
    {

        public override List<BankTransfer> GetBankTransfers()
        {
            BankFileOperation = new SieradzFileOperation();
            XmlDocument xmlFile= new XmlDataDocument();
            List<BankTransfer> mBankTransferList = new List<BankTransfer>();
            xmlFile.LoadXml(BankFileOperation.GetFileContent(SieradzBankFilesPathHolder.TransferFilesPath + @"mBankTransfers.xml"));
            foreach (var childNode in xmlFile.DocumentElement.ChildNodes)
            {
                GetTransferEntry(xmlFile.GetElementsByTagName((string) childNode.GetType().GetProperty("Name").GetValue(childNode)).Item(0).InnerXml); 
            }
                
            return mBankTransferList;

        }

        protected override BankTransfer GetTransferEntry(string entry)
        {
            var mBankTransfer = new SieradzBankTransfer();
            XmlDocument xmlNode = new XmlDataDocument();
            string datePattern = "d.m.yyyy";
            DateTime currentDate = DateTime.Now;
            
            xmlNode.LoadXml(entry);
            //TODO it's possible to reduce that sphagetti?
            mBankTransfer.SourceBank = xmlNode.GetElementsByTagName("SourceBank").Item(0).InnerText;
            mBankTransfer.DestinationBank = xmlNode.GetElementsByTagName("DestinationBank").Item(0).InnerText;
            mBankTransfer.TransferInfo.Amount = xmlNode.GetElementsByTagName("Amount").Item(0).InnerText;
            mBankTransfer.TransferInfo.DestinationAccountNumber = xmlNode.GetElementsByTagName("DestinationAccountNumber").Item(0).InnerText;
            mBankTransfer.TransferInfo.DestinationPersonName = xmlNode.GetElementsByTagName("DestinationPersonName").Item(0).InnerText;
            mBankTransfer.TransferInfo.SourceAccountNumber = xmlNode.GetElementsByTagName("SourceAccountNumber").Item(0).InnerText;
            mBankTransfer.TransferInfo.TransferDate = currentDate.ToString(datePattern);
            mBankTransfer.TransferInfo.TransferTitle = xmlNode.GetElementsByTagName("TransferTitle").Item(0).InnerText;
            return mBankTransfer;

        }
    }
}