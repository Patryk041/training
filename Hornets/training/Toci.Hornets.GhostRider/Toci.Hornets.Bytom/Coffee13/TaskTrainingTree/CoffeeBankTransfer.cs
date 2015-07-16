using System;
using System.Data;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree
{
    internal class CoffeeBankTransfer : BankTransfer
    {
        public CoffeeAccountInfo SourceInfo { get; set; }
        public CoffeeAccountInfo DestinationInfo { get; set; }
        public decimal TransferAmount { get; set; }
        public string TitleOfTransfer { get; set; }
        public DateTime DateOfTransfer { get; set; }
        public DateTime DateOfRecord { get; set; }

        //type of transfer
    }
}