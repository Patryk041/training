using System.Collections;
using System.Linq;

namespace Anathema.Terry
{
    public static class StringExtensions
    {
        public static string OurExtension(this IEnumerable str)
        {
            str = "ala ma kota";
            return null;
        } 

        public static string SortToci(this string str)
        {
            return new string(str.OrderBy(x=>x).ToArray());
        }

        public static void GenericExtensionWorksEverywhere<T>(this T nazwa) where T : IEnumerable
        {
            
        }
    }
}