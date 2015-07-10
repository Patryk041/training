using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.GhostRider.TrainingTwo.Homework
{
    public class GhostRoderPeselValidator : PeselValidator
    {
        protected override bool ValidateDate(int year, int month, int day)
        {
            throw new NotImplementedException();
        }
    }
}
