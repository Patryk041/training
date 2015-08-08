using System;
using System.Diagnostics;
using System.Linq;

namespace Toci.Hornets.Legnica.Amman.DelegatesSandbox
{
    public class DelegatesSandbox
    {
        public delegate void Work(string test1);

        private const string TextMessage = "Wake up! You've been idle for 3 minutes. Scroll, click or press any key to dismiss.";

        public void Test()
        {
            Work wtf = _5thLetter;

            wtf += Cokolwiekinnego;

                wtf(TextMessage);
            
        } 
        public void _5thLetter(string message)
        { 
            var letter = message.ElementAt(5);
            Debug.WriteLine(letter);
        }

        public void Cokolwiekinnego(string message)
        {
            Debug.WriteLine("Length: " + message.Length);
        }
    }
}