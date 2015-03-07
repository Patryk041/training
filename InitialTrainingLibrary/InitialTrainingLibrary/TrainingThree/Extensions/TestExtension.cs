using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingThree.Extensions
{
    class TestExtension
    {
        public void test()
        {
            string t = "raadr";
            t.IsPalindrom();
            t.IsAnagram("radar");

            Dictionary<string, string> test = new Dictionary<string, string>();

            test.GetPalindromSet();
        }
    }
}
