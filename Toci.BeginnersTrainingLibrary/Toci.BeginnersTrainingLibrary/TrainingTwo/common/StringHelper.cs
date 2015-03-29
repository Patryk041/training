using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.common
{
    public static class StringHelper
    {
        public static List<string> GetSeparatedItems(string separator, string line)
        {
            return line.Split(new []{separator}, StringSplitOptions.None).ToList();
        }
    }
}
