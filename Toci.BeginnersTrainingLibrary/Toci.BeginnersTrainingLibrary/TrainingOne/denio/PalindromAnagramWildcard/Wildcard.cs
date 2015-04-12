using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard
{
    public class Wildcard
    {
        public string[] GetWildcard(string szukana ,List<string> items)
        {
            return items.Where((text) => text.StartsWith(szukana)).ToArray();
        }
    }
}
