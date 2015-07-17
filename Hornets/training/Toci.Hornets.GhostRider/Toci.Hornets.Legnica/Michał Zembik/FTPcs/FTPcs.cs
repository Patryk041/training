using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Legnica.Michał_Zembik.FTPcs;


namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    public static class FTPcs
    {
        private static string _login = "srv29007", _pass = "l2aBP8vT", _server = "ftp://p.1shot1kill.pl/banki/";

        /* public FTPcs(string serverpath, string login, string pass)
         {
             _login = login;
             _pass = pass;
             _server = serverpath; //ftp::jakisserwer.pl/folder/
         }*/

        public static bool Send(BankTransfer transfer)
        {
            string bankname = transfer.DestinationBank;
            var sender = new SendFile();
            var desinationfilepath = _server + bankname + ".txt"; //ftp::jakisserwer.pl/folder/plik.txt
            var file = bankname + ".txt";
            return sender.Send(file, desinationfilepath, _login, _pass);
        }

        public static string Get(string file)
        {
            string bankname = file;
            var geter = new GetFile();
            var sourcefilepath = _server + bankname + ".txt";
            return geter.Get(sourcefilepath, _login, _pass);
        }

        public static void OverWriteFile(BankTransfer transfer, string newline)
        {
            Get("asd");

            Send(transfer);
        }


    }
}
