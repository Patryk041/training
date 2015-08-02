using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzBankTransfersUtils
    {
        private static readonly SieradzBankTransfersUtils instance = new SieradzBankTransfersUtils();

        static SieradzBankTransfersUtils(){}

        private SieradzBankTransfersUtils()
        {
            GetBankNamesDictionary();
        }

        public static SieradzBankTransfersUtils Instance
        {
            get { return instance; }
        }

        private Dictionary<string, string> _bankNamesDictionary = new Dictionary<string, string>();

        public string GetBankName(string bankCode)
        {
            return _bankNamesDictionary[bankCode];
        }

        private void GetBankNamesDictionary()
        {
            _bankNamesDictionary = File.ReadAllLines(SieradzBankFilesPathHolder.ConfigPath).Select(line => line.Split(' ')).Where(splitedLine => splitedLine[0].Length == 4).ToDictionary(splitedLine => splitedLine.First(), splitedLine => splitedLine.Last());
        }
    }
}