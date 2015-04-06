using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Skills
{
    public abstract class SkillBase
    {
         protected SkillBase(string name, int quality, int speed)
        {
            Name = name;
            QualityOfPerformance = quality;
            SpeedOfPerformance = speed;
            
        }

      

        public string Name { get; set; }
        public int QualityOfPerformance { get; set; }
        public int SpeedOfPerformance { get; set; }
        protected int CountOfTricks { get; set; }
        protected int CountOfSuccesfullTricks { get; set; }
        protected int CountOfFailTricks { get; set; }

        public abstract void DoTrick();
        public abstract void ImproveSkill();


    }
}
