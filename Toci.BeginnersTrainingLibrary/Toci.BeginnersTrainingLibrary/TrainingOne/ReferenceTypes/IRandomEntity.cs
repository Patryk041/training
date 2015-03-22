using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes
{
    public interface IRandomEntity
    {
        string Name { get; set; }

        int Test { get; set; }

        string Nick { get; set; }

        int Skill { get; set; }
    }
}
