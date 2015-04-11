using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Erley.ErleyDateValidator
{
    public interface IErleyDateEntity
    {
        bool day { get; set; }
        bool month { get; set; }
        bool year { get; set; }
    }
}
