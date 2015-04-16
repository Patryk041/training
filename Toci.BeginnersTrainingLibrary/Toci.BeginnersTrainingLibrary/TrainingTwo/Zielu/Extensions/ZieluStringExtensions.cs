using System.IO;

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
