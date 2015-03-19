using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Toci.TraininigLibrary.Developers.Chmura.Common
{
    public static class ChmuraExceptionMessages
    {
        private static CultureInfo _polish = CultureInfo.GetCultures(CultureTypes.AllCultures).FirstOrDefault(item => item.Name == "pl-PL");
        private static CultureInfo _english = CultureInfo.GetCultures(CultureTypes.AllCultures).FirstOrDefault(item => item.Name == "en-EN");

        public static Dictionary<CultureInfo, string> ReturnBeforeDepartureEx = new Dictionary<CultureInfo, string>
        {
            {_polish, "Data powrotu jest wczesniej niz data wyjazdu"},
            {_english, "The date of return is before the date of departure"}
        };
        public static Dictionary<CultureInfo, string> DateOverlaps = new Dictionary<CultureInfo, string>
        {
            {_polish, "Daty nakładają sie na siebie. Istnieje na lisnie rekeord dla ktorego daty sie nakladaja."},
            {_english, "The date of return and / or departure is already on the list, and it overlaps it."}
        };
    }
}
