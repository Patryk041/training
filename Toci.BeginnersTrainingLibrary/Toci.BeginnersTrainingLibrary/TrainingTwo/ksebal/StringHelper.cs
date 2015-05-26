using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ksebal
{
    public static class StringHelper
    {
        public static List<string> GetSeparatedItems(string separator, string line)
        {
            return line.Split(new []{separator}, StringSplitOptions.None).ToList();
        }
    }
}
