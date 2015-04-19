using System;
using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.Disposables
{
    public class DisposableList<T> : List<T>, IDisposable
    {
        public void Dispose()
        {
            this.Clear();
        }
    }
}
