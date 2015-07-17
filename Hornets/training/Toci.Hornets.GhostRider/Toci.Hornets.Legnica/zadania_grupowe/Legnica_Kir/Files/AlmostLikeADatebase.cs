using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.Files
{
    public static class AlmostLikeADatebase
    {
        private static readonly string StartupPath = @"..\\..\\..\\Toci.Hornets.Legnica\\zadania_grupowe\\Legnica_Kir\\Files\\";

        public static List<string> GetBankTransferToDo(string bankName)
        {
            var path = StartupPath + "BankTransfersToDo\\" + bankName;
            return Directory.GetFiles(path).ToList();
        }

        public static void SaveBankTransfer(LegnicaBankTransfer bankTransfer)
        {
            var bankName = bankTransfer.DestinationBank;
            var path = StartupPath + "TransfersReceived\\" + bankName + "\\" + bankName + ".txt";
            FileStream fs = new FileStream(path,FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(bankTransfer);
            sw.Close();
            fs.Close();
        }

    }
}