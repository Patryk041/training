using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.async
{
    public class OldStyle
    {
        private Func<bool> asyncDelegate = new Func<bool>(WaitSomeTime);

        private static bool WaitSomeTime()
        {
            Thread.Sleep(10000);

            return true;
        }

        public void test()
        {
            var result = asyncDelegate.BeginInvoke(callback, 8);

            int dsa = 6;

            asyncDelegate.EndInvoke(result);
        }

        private void callback(IAsyncResult result)
        {
            //result.
            int i = 5;

            //return null;
        }
    }
}
