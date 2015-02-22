using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.dispose
{
    public class RamExhauster
    {
        private static int threadsCount = 100;
        List<ExampleTask> taskList = new List<ExampleTask>(threadsCount);

        public void ExhaustRam()
        {
            for (int i = 0; i < threadsCount; i++)
            {
                taskList.Add(new ExampleTask());
                taskList[i].Start();
            }
        }

        public void Wait()
        {
            foreach (var task in taskList)
            {
                task.Wait();
            }
        }
    }
}
