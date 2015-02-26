using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InitialTrainingLibrary.syf.proofsofconcept.dispose
{
    public class DisposableListExample<T> : List<T>, IDisposable
    {
        static int counter = 0;

        public DisposableListExample(int size) : base(size)
        {
            
        }

        public void Dispose()
        {
            this.Clear();
            GC.ReRegisterForFinalize(this);
            counter++;

            if (counter%100 == 0)
            {
                GC.Collect();
                Debug.WriteLine("Coolect counter: {0}", counter);
            }
        }
    }
}
