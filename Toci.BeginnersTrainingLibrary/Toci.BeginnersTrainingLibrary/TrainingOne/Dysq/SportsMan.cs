using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq.Helper;
using Toci.BeginnersTrainingLibrary.TrainingOne.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq
{
    public abstract class SportsMan : IHuman, ISportsMan
    {
        private int _age = 18;
        //protected string Name;
        protected string Surname;
        protected string SportsField;
        public bool allowed;
        //protected SportsmanSkill Skill = new 

        public virtual bool DoesHeWantToTrick(SportsmanSkill trick)
        {

            trick.DoTrick();

            return true;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }

        public SportsMan(int age, string name, string surname, string sportsField)
        {
            //Name = name;
            Surname = surname;
            SportsField = sportsField;
            _age = age;

            allowed = AllowedToPlay.CheckPlayer(this);

        }


        public int Gender()
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public bool HasSkill(ISportSkill skill)
        {
            throw new NotImplementedException();
        }
    }
}
