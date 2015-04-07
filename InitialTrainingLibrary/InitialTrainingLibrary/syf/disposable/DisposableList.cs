using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.disposable
{
    class DisposableList<T> : List<T>, IDisposable
    {
        public void Dispose()
        {
            //ConcurrentBag<int>
            this.Clear();

            GC.ReRegisterForFinalize(this);

            GC.Collect();
        }
    }
}
