using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace Toci.Hornets.Kalisz.Adrianowsky94.PeselValidatorHW.PeselManipulationMethods
{
    public class DateCutter
    {
        public static string Cut(string pesel)
        {
            int peselParsedToNumber = 0;
            if (pesel.Length != 11 && !int.TryParse(pesel, out peselParsedToNumber))
            {
                throw new Exception("PESEL IS INVALID");
            }
            else
            {
                Date.year = Int32.Parse(pesel.Substring(0, 2));
                Date.month = Int32.Parse(pesel.Substring(2, 2));
                Date.day = Int32.Parse(pesel.Substring(4, 2));

                return pesel.Substring(0, 6);
            }
        }
    }
}