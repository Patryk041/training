using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes
{
    public class ManipulateNameHandle : IChainOfResponsibilityFriendly
    {
        public void Handle(IRandomEntity entity)
        {
            //logika ktora ten text skads bierze

            entity.Name = "chain of responsibility explanation";
        }
    }
}
