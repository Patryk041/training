using System;
using System.IO;

namespace Toci.Hornets.Bytom.Szary.TrainingThree
{
    public class UserrPath
    {
        public static string Find()
        {
            var path = Directory.GetCurrentDirectory();

            var nowy = path.IndexOf("Toci.Hornets.GhostRider", StringComparison.Ordinal);

            path = path.Remove(nowy + "Toci.Hornets.GhostRider".Length) + "\\Toci.Hornets.Bytom\\Szary\\BankTransfers";



            return path;
        }
    }
}