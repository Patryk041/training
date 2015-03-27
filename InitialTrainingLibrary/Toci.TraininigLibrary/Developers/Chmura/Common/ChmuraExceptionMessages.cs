using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Toci.TraininigLibrary.Developers.Chmura.Common
{
    public static class ChmuraExceptionMessages
    {
        public static Dictionary<CultureInfo, string> DateOverlaps = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "Daty nakładają sie na siebie. Istnieje na lisnie rekeord dla ktorego daty sie nakladaja."},
            {new CultureInfo("en-US"), "The date of return and / or departure is already on the list, and it overlaps it."}
        };
        public static Dictionary<CultureInfo, string> NotProperDate = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "Przynajmniej jedna z dat nie jest poprawna data."},
            {new CultureInfo("en-US"), "At least one of the dates is not proper."}
        };
        public static Dictionary<CultureInfo, string> ReturnBeforeDeparture = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "Data powrotu jest wczesniej niz data wyjazdu."},
            {new CultureInfo("en-US"), "The date of return is before the date of departure."}
        };
        public static Dictionary<CultureInfo, string> NoSuchClient = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "Brak takiego klienta na liscie, w tych butach nie wejdziesz."},
            {new CultureInfo("en-US"), "There is no such client on my list."}
        };
        public static Dictionary<CultureInfo, string> WrongSection = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "Podany klient nie znajduje sie w odpowiedniej sekscji."},
            {new CultureInfo("en-US"), "Pointed client is not in a proper section."}
        };
        public static Dictionary<CultureInfo, string> CantRetriveStatus = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "System nie jest w stanie okreslic statusu."},
            {new CultureInfo("en-US"), "System can not set any proper status."}
        };
        public static Dictionary<CultureInfo, string> WrongStatus = new Dictionary<CultureInfo, string>
        {
            {new CultureInfo("pl-PL"), "Przydzielony status jest bledny."},
            {new CultureInfo("en-US"), "Status of departure is incorrect."}
        };
        
    }
}
