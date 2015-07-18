using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.AdamPast.GipsonKIR
{
    public static class GipsonKirUtils
    {
        public static string CutOneField(string entry)
        {
            int i = 0;
            while (!(entry[i].ToString()).Equals(";"))
            {
                i++;
            }
            return entry.Substring(0, i);
        }

        public static string CutTail(string entry)
        {
            int i = 0;
            while (!(entry[i].ToString()).Equals(";"))
            {
                i++;
            }
            return entry.Substring(i + 1);
        }
        /*public static Dictionary<string , Func<BankTransfer,bool>> BankDictionary = new Dictionary<string, Func<BankTransfer, bool>>()
        {
            {"ING Bank", delegate(BankTransfer transfer) 
            { //wywolanie zapisu dla ING
                return true;
            }},
            {"BZ WBK", delegate(BankTransfer transfer)
            {
                //wywolanie zapisu dla BZWBK
                return true;
            }}
        };*/
    }
}