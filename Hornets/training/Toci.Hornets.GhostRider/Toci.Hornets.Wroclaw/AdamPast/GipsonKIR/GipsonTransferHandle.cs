using System.IO;
using System.Runtime.CompilerServices;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.AdamPast.GipsonKIR
{
    public class GipsonTransferHandle : TransferHandle
    {
        protected string SaveFilePath = @"..\..\..\Toci.Hornets.Wroclaw\AdamPast\GipsonKIR\CompletedTransfers\";
        /*public GipsonTransferHandle(string bankName)
        {
            this.BankName = bankName;
        }*/

        public GipsonTransferHandle()
        {
            BankName = "BankGipsona";
        }


        protected override bool Send(BankTransfer transfer)
        {
            string transferFilename = SaveFilePath+transfer.SourceBank+"_TO_"+BankName+".txt";

            File.WriteAllText(transferFilename,transfer.ToString());
            transfer.IsTransferSuccessful = true;

            //pomysl
            //zaleznie od nazwy banku wywoluje rozne funkcje(inaczej zapisuje transfer)
            //rozne opcje zapisane w slowniku i wywolywane przez delegaty, w ktorych wywolane konkretne metody

            //zapis transferu do pliku w folderze z transferami
            return true;
        }
    }
}