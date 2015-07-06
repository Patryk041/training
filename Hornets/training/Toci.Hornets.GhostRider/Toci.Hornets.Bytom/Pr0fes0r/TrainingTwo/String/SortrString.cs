using System;
using System.Globalization;

namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.String
{
    public class SortrString
    {
        public Stringi Sort(string subject, string seek)
        {
           var subjectChar = subject.ToCharArray();
           var seekChar    = seek.ToCharArray();

           Array.Sort(subjectChar);
           Array.Sort(seekChar);

            return new Stringi(subjectChar, seekChar);
        }
    }

    public class Stringi
    {
        public Stringi(char[] subjectChar, char[] seekChar)
        {
            throw new NotImplementedException();
        }
    }

    public class String
    {
        public Stringi(char[] subject, char[] seek);
        {
            
        }
    }
}