using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Skills
{
    public class FootballSkill : SkillBase
    {
        public FootballSkill(string name, int quality, int speed) : base(name,quality,speed)
        {
            Name = name;
            QualityOfPerformance = quality;
            SpeedOfPerformance = speed;
            DoTrick();
        }

        public override void DoTrick()
        {
            
        }

        public override void ImproveSkill()
        {
            throw new NotImplementedException();
        }
    }
}
