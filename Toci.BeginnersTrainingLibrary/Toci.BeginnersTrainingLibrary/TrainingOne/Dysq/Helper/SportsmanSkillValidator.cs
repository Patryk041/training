using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq.Helper
{
    public static class SportsmanSkillValidator
    {
        private const int MaxSpeed = 10;

        public static bool VerifySpeed(SportsmanSkill skill)
        {
            //return skill.GetSpeedPerformance() <= MaxSpeed;
            return true;
        }

        public static bool TestGenericDelegate(string test, int dupa)
        {
            return true;
        }
    }
}
