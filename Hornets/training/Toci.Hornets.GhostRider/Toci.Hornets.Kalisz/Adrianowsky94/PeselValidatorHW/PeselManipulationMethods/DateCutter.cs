using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods
{
    public class DateCutter
    {
        public static string Cut(string pesel)
        {
            if (pesel.Length != 11 && !pesel.Contains("0123456789"))
                throw new Exception("TYPED NUMBER IS NOT PESEL");
            else
            {
                Date.year = Int32.Parse(pesel.Substring(0,2));
                Date.month = Int32.Parse(pesel.Substring(2,2));
                Date.day = Int32.Parse(pesel.Substring(4,2));

                return pesel.Substring(0, 6);
            }
        }
    }
}