using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.warrior.EnumerableImplementations
{
    public class CustomGenericEnumerator<T> : IEnumerator<T>
    {
        //tu dla smiechu mamy tablice 8 elementowa. nalezy oprogramowac ganianie po tablicy jej uzupelnianie i dostrajanie
        protected T[] items = new T[8];
        protected int index = 0;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (index < items.Length - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            index = 0;
        }

        public T Current
        {
            get
            {
                return items[index];
            }
            private set
            {
                items[index] = value;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
