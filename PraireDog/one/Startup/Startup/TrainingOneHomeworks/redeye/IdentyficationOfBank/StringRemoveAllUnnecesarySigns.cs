using System.Text.RegularExpressions;

namespace Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank
{
    static public class StringRemoveAllUnnecesarySigns
    {
        public static string RemoveUnnecesarySigns(this string text, string SignsToremove)
        {
            foreach (char sign in SignsToremove)
            {
                text = text.Replace(sign.ToString(), "");
            }

            return text;
        }
    }
}