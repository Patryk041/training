using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac.Features.LightweightAdapters;

namespace InitialTrainingLibrary.warrior.tpl
{
    public class ParallelProcessing
    {
        public virtual void ProcessInParallel(int threadsCount, Func<object, bool> tester, object data)
        {
            for (int i = 0; i < threadsCount; i++)
            {
                TaskFactory tf = new TaskFactory();

                Task t = tf.StartNew(tester, data);
            }
        }
    }
}
