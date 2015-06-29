using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task
{
    public class DummyStringComparator : IStringComparator
    {
        public bool CompareTwoStrings(string s1, string s2)
        {
            return true;
        }
    }
}