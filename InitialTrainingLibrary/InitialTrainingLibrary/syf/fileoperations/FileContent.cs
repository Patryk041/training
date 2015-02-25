using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.fileoperations
{
    class FileContent
    {
        [Parse("name")]
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Data { get; set; }
    }
}
