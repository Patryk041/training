using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ExtensionMethods
{
    public static class ExtMethodsShowdown
    {
        public static bool Whatever(this IDateValidator validator, string ultraWhetver)
        {
            if (!validator.CheckDate(2103, 13, 32) || ultraWhetver == "s2yf4nt")
            {
                return true;
            }
            return false;
        }

        public static bool IsPalindrom(string text) //this
        {
            return text.ToCharArray().SequenceEqual(text.Reverse());
        }
    }
}
