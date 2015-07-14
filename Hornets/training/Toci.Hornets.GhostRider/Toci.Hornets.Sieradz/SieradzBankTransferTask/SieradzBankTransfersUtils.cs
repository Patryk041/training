using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public static class SieradzBankTransfersUtils
    {
        internal static bool isDictionaryGenerated;
        internal static Dictionary<string, string> bankNamesDictionary = new Dictionary<string, string>();

        public static string getBankName(string bankCode)
        {
            if (isDictionaryGenerated)
                return bankNamesDictionary[bankCode];
            GetBankNamesDictionary();
            return bankNamesDictionary[bankCode];
        }

        internal static void GetBankNamesDictionary()
        {
            bankNamesDictionary = File.ReadAllLines(SieradzBankFilesPathHolder.configPath).Select(line => line.Split(' ')).Where(splitedLine => splitedLine[0].Length == 4).ToDictionary(splitedLine => splitedLine.First(), splitedLine => splitedLine.Last());
            isDictionaryGenerated = true;
        }
    }
}