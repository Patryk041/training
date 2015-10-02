using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toci.Hornets.GhostRider.TrainingFive.Tpl
{
    public class ParallelFileParserManager
    {


        public void ManageFile(string path, int numberOfSequences)
        {
            TaskFactory tf = new TaskFactory();

            List<Task> tasksList = new List<Task>();

            for (int i = 0; i < numberOfSequences; i++)
            {
                //var task = tf.StartNew<string>(GetFileFragment);
                Task<string> task = new Task<string>(GetFileFragment);

                tasksList.Add(task);
            }

            //ConcurrentBag<string> f = new ConcurrentBag<string>();
            //f.
            //Task.WaitAll()
            tasksList.Select(item =>
            {
                item.Start();
                return item;
            });

            //tasksList.
        }

        private string GetFileFragment()
        {
            var test = Environment.CurrentManagedThreadId;
            //this.
            return "dfsw";
        }
    }
}