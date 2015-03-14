using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.TrainingFour.Reflection.Training;

namespace InitialTrainingLibrary.warrior.EnumerableImplementations
{
    public class CustomGenericEnumerable<T> : IEnumerable<T>
    {
        protected CustomGenericEnumerator<T> items = new CustomGenericEnumerator<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
