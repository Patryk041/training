using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes
{
    public class ManipulateNickHandle : IChainOfResponsibilityFriendly
    {
        public void Handle(IRandomEntity entity)
        {
            entity.Nick = "dupa";
        }
    }
}
