using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Rzeszow.KSebal.traningThreeHomework
{
   public static class UserPath
    {
       public static string find()
       {
           string path = Directory.GetCurrentDirectory();

           int nowy = path.IndexOf("Toci.Hornets.GhostRider");

           path = path.Remove(nowy + "Toci.Hornets.GhostRider".Length) + "\\Toci.Hornets.Rzeszow\\KSebal\\BankTransfers";

          

           return path;


       }
    }
}
