using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Chmura.Common
{
    public static class ChmuraLanguageEngine
    {
        public static List<CultureInfo> SupportedLanguages = new List<CultureInfo>
        {
            {new CultureInfo("pl-PL")},
            {new CultureInfo("en-US")}
        };
        public static CultureInfo DefaultLanguage = new CultureInfo("en-US");

        public static CultureInfo GetLanguage()
        {
            return SupportedLanguages.Contains(CultureInfo.InstalledUICulture)
                ? CultureInfo.InstalledUICulture
                : DefaultLanguage;
        }
    }
}
