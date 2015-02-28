using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.disposable
{
    class FileReader : IDisposable
    {
        public void ReadText()
        {
            int dsaf = 5;
        }

        public void Dispose()
        {
            int siemaheniu = 4;

            GC.SuppressFinalize(this);

            GC.ReRegisterForFinalize(this);

            GC.Collect();
        }
    }
}
