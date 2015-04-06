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

      

        protected string Name { get; set; }
        protected int QualityOfPerformance { get; set; }
        protected int SpeedOfPerformance { get; set; }
        protected int CountOfTricks { get; set; }
        protected int CountOfSuccesfullTricks { get; set; }
        protected int CountOfFailTricks { get; set; }

        protected abstract void DoTrick();



    }
}
