using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq.Helper
{
    public static class AllowedToPlay
    {
        private const int _age = 15;

        public static bool CheckPlayer(SportsMan man)
        {
            return man.GetAge() > _age;
        }
    }
}
