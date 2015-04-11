using System.Collections.Generic;
using System.Management.Instrumentation;
using Toci.TraininigLibrary.Developers.Dysq.omr.Moves;
using Toci.TraininigLibrary.Developers.Dysq.omr.Skills;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.SportsManModel
{
    public abstract class SportsManBase
    {
        protected int Age { get; set; }
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected double Height { get; set; }
        protected double Weight { get; set; }
       // public string SkillName { get; set; }

        protected SportsManBase(
            int age, string name, string surname, double height, double weight, int agi, int str, int exp)
        {

        }

        protected int Agility { get; set; }
        protected int Strenght { get; set; }
        protected KindOfSport SportsField;
        protected int ExperienceInYears { get; set; }

        
        protected List<SkillBase> SportsManSkills;

        public abstract List<SkillBase> GetPlayerSkills();
        public abstract void LearnSkill(string skillName, int qualityOfPerformance, int speedOfPerformance);
        public abstract SkillBase ChoseAndUseSkill(string skillName);
        public abstract void ImproveSkill(string skillName, int quality, int speed);


    }
}
