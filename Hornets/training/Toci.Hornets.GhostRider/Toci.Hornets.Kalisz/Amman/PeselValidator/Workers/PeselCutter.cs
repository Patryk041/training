using System;

namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers
{
    public class PeselCutter
    {
        public static string Cut(string psl)
        {
            if (psl.Length<6) throw new Exception("NOT ENOUGH CHARACTERS TO START CUTTING"); //TODO check if necessary
            return psl.Substring(0, 6);
        }
    }
}