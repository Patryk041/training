using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.sourcetree
{
    interface ISourceTreeConflictType
    {
        bool IsConflict();

        string GetName();
    }
}
