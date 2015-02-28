using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.bank.Interfaces;

namespace InitialTrainingLibrary.syf.bank
{
    class File<THeader, TDetails, TFooter> where THeader : IFileSection where TDetails : IFileSection where TFooter : IFileSection
    {
        private THeader header;
        private TDetails details;
        private TFooter footer;

        private StreamReader reader;

        private void Open()
        {
            
        }

        private void Read()
        {
            header.ReadEntry(reader);

            //details.ReadEntry()
        }
    }
}
