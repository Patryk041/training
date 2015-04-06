using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.omr.Skills;
using Toci.TraininigLibrary.Developers.Dysq.omr.SportsManModel;

namespace Toci.TraininigLibrary.Developers.Dysq.omr
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(int age, string name, string surname, double height, double weight, int agi, int str, int exp) : base(age,name,surname,height,weight,agi,str,exp)
        {
            this.SportsField = KindOfSport.Football;
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            this.Height = height;
            this.Weight = weight;
            this.Agility = agi;
            this.Strenght = str;
            this.ExperienceInYears = exp;
            this.SportsManSkills = new List<SkillBase>();
        }



        public override void LearnSkill(string skillName, int qualityOfPerformance, int speedOfPerformance)
        {
         SportsManSkills.Add(new FootballSkill(skillName,(int)((((Height + Weight / 2) + ExperienceInYears+Strenght+Agility)+qualityOfPerformance)/4),
          (int)((Agility+Strenght+ExperienceInYears+speedOfPerformance))/4));
          
        }

        public override List<SkillBase> GetPlayerSkills()
        {
            return this.SportsManSkills;
        }

        public override SkillBase ChoseAndUseSkill(string skillName)
        {
            SkillBase skillToUse=null;
            foreach (var skill in this.SportsManSkills.Where(skill=>skill.Name.Equals(skillName)))
            {
                skillToUse= skill;
                skillToUse.DoTrick();
            }
            return skillToUse;
        }

        public override void ImproveSkill(string skillName, int quality, int speed)
        {
            foreach (var skill in this.SportsManSkills.Where(skill => skill.Name.Equals(skillName)))
            {
                skill.QualityOfPerformance += quality;
                skill.SpeedOfPerformance += skill.SpeedOfPerformance + speed;
            }
        }
    }
}
