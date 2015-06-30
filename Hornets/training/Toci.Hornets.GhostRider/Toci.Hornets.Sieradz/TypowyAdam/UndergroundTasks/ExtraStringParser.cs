using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Toci.Hornets.Sieradz.Undergroun1Task.Interface;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public class ExtraStringParser : IStringComparator
    {

        private int s1LetterAmount, s2LetterAmount;

        public bool CompareTwoStrings(string s1, string s2)
        {

            /*   Task s1Thread = new Task(() => { s1LetterAmount = s1.Where(char.IsLetter).Count(); });
               s1Thread.Start();
               Task s2Thread = new Task(() => { s1LetterAmount = s1.Where(char.IsLetter).Count(); });
               s2Thread.Start();
               s1Thread.Wait();
               s2Thread.Wait();*/

            /*   Thread th1 = new Thread(() => { s1LetterAmount = s1.Where(char.IsLetter).Count(); });
               th1.Start();
               Thread th2 = new Thread(() => { s1LetterAmount = s1.Where(char.IsLetter).Count(); });
               th2.Start();
               th1.Join();
               th2.Join();*/

            //Parallel.Invoke(() => { s1LetterAmount = s1.Where(char.IsLetter).Count(); }, () => { s2LetterAmount = s1.Where(char.IsLetter).Count(); });
            
            var myTasks = new Task[0];
            {
                Task.Factory.StartNew(() => { s1LetterAmount = s1.Where(char.IsLetter).Count(); });
                Task.Factory.StartNew(() => { s2LetterAmount = s2.Where(char.IsLetter).Count(); });   
            }
            Task.WaitAll(myTasks);
            return s1LetterAmount == s2LetterAmount;
        }

       


    }
}