using System;
using System.Data;
using System.Xml.Serialization;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree
{
    [Serializable()]
    [XmlRoot("AllTransfers")]
    public class CoffeeBankTransfer : BankTransfer
    {
        [XmlArray("Transfers")]
        [XmlArrayItem("Transfer",typeof(Transfer))]
        public Transfer[] Transfer { get; set; }
    }

    [Serializable()]
    public class Transfer
    {
        [XmlElement("SourceAccountNumber")]
        public string SourceAccountNumber { get; set; }

        [XmlElement("SourceName")]
        public string SourceName { get; set; }

        [XmlElement("SourceAddress")]
        public string SourceAddress { get; set; }

        [XmlElement("SourceBank")]
        public string SourceBank { get; set; }

        [XmlElement("DestinationAccountNumber")]
        public string DestinationAccountNumber { get; set; }

        [XmlElement("DestinationName")]
        public string DestinationName { get; set; }

        [XmlElement("DestinationAddress")]
        public string DestinationAddress { get; set; }

        [XmlElement("DestinationBank")]
        public string DestinationBank { get; set; }

        [XmlElement("TransferType")]
        public string TransferType { get; set; }

        [XmlElement("Amount")]
        public decimal Amount { get; set; }

        [XmlElement("TitleOfTransfer")]
        public string TitleOfTransfer { get; set; }

        [XmlElement("DateOfTransfer")]
        public string DateOfTransfer { get; set; }

        [XmlElement("DateOfRecord")]
        public string DateOfRecord { get; set; }
    }
}