namespace Toci.Hornets.Legnica.Adrianowsky94.StringManipulator.CheckingMethods
{
    public class StringContainString
    {
        public static bool OneInAnother(string subject, string seek)
        {
            return subject.Length == seek.Length && subject.Contains(seek);
        }
    }
}