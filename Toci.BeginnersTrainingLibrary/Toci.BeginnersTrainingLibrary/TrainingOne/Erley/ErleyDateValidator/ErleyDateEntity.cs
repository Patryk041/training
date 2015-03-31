using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Erley.ErleyDateValidator
{
    public class ErleyDateEntity : IErleyDateEntity
    {
        public bool day { get; set; }
        public bool month { get; set; }
        public bool year { get; set; }
    }
}
