using System;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils
{
    public static class DuchStringUtils
    {
        private const string Space = " ";
        private const string Empty = "";
        private const string NewLine = "\n";
        private const string CrReturn = "\r";
        private const string Tab = "\t";


        public static string DuBetterReplace(this string msg)
        {
            return msg.Replace(Space , Empty).
                       Replace(NewLine,Empty).
                       Replace(CrReturn,Empty).
                       Replace(Tab,Empty);
        }


    }
}