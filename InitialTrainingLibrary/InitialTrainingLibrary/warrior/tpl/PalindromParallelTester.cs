using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using InitialTrainingLibrary.syf.algorythmics;
using Toci.TraininigLibrary.Developers.Chmura.Common;

namespace InitialTrainingLibrary.warrior.tpl
{
    public class PalindromParallelTester
    {
        private ParallelProcessing processing = new ParallelProcessing();

        private Dictionary<string, int> results = new Dictionary<string, int>();
 
        //    return s.ChmuraIsPalindrom();
        

        private bool RunInParallel(object palindromCandidates)
        {
            foreach (var palindromCandidate in (List<string>)palindromCandidates)
            {
                if (results.ContainsKey(Thread.CurrentThread.ManagedThreadId.ToString()))
                {
                    results[Thread.CurrentThread.ManagedThreadId.ToString()] += palindromCandidate.ChmuraIsPalindrom() ? 1 : 0;
                }
                else
                {
                    results.Add(Thread.CurrentThread.ManagedThreadId.ToString(), palindromCandidate.ChmuraIsPalindrom() ? 1 : 0);
                }
               
            }

            return true;
        }

        public void RunParallelProcessing(List<string> palindromCandidates)
        {
            processing.ProcessInParallel(16, RunInParallel, palindromCandidates);
        }
    }
}