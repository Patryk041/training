using System.Collections;
using System.Collections.Generic;

namespace Toci.Hornets.Kalisz.Adrianowsky94.StringManipulator.CheckingMethods
{
    public class ListOfStringManipulation
    {
        public static List<string> lettersInSubject = new List<string>();
        public static List<string> lettersInSeek = new List<string>();

        public static void ToList(string subject, string seek)
        {

            foreach (char letter in subject)
            {
                lettersInSubject.Add(letter.ToString());
            }

            lettersInSubject.ToArray();

            foreach (char letter in seek)
            {
                lettersInSeek.Add(letter.ToString());
            }

            lettersInSeek.ToArray();
        }

        public static void SortList()
        {
            lettersInSubject.Sort();
            lettersInSeek.Sort();
        }
    }
}