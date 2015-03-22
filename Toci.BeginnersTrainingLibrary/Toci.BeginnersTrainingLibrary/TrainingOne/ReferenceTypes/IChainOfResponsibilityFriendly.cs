using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes
{
    public interface IChainOfResponsibilityFriendly
    {
        void Handle(IRandomEntity entity);
    }
}
