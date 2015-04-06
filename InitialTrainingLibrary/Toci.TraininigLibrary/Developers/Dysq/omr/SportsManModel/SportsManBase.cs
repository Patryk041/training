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
        public string SkillName { get; set; }

        protected SportsManBase(int age, string name, string surname, double height, double weight, int agi, int str, KindOfSport sportName, int exp)
        {

        }

        protected int Agility { get; set; }
        protected int Strenght { get; set; }
        protected KindOfSport SportsField;
        protected int ExperienceInYears { get; set; }

        
        public List<SkillBase> SportsManSkills = new List<SkillBase>();


        public virtual void LearnFootballSkill(SkillBase skill)
        { 
           
            SportsManSkills.Add(new FootballSkill(SkillName,(int)((Height + Weight / 2) + ExperienceInYears+Strenght+Agility),
                Agility+Strenght+ExperienceInYears));

        }

        public virtual void LearnDriveSkills()
        {}
        public virtual void LearnVolleyballSkills()
        { }

    }
}
