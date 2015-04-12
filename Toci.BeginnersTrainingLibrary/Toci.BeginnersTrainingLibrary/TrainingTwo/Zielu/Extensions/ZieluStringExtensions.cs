using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Zielu.Extensions
{
    public static class ZieluStringExtensions
    {
        public static string GetFileName(this string path)
        {
            return Path.GetFileName(path);
        }
    }
}
