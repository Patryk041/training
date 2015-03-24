using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq.Helper;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq
{
    public abstract class SportsmanSkill
    {
        private int tosieniedziedziczy;

        protected string Type { get; set; }
        protected string Name { get; set; }
        protected int SpeedOfPerformance { get; set; }
        protected int CountOfTricks { get; set; }
        protected int CountOfSuccessfulTricks { get; set; }


        public int GetSpeedPerformance()
        {
            return SpeedOfPerformance;
        }

        protected SportsmanSkill()
        {
            SpeedOfPerformance = 5;

            var test = SportsmanSkillValidator.VerifySpeed(this);
            if (!test)
            {
                throw  new Exception("nie pasuje predkosc triku");
            }
        }

        public int QualityOfPerformance()
        {
            return 3;
        }

        public abstract bool DoTrick();

        
    }
}
