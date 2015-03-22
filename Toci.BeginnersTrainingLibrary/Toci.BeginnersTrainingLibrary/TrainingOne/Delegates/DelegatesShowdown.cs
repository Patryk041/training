using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq.Helper;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Delegates
{
    public class DelegatesShowdown
    {
        protected delegate bool WarriorDelegate(SportsmanSkill skill);
        protected delegate bool WarriorGenericDelegate<T, T2>(T param1, T2 param2);


        public void test()
        {
            WarriorDelegate del = new WarriorDelegate(ToJestTest);

            del += ToJestTest;

            del += SportsmanSkillValidator.VerifySpeed;

            var result = del(new FootballTrick());

            //Func<int>

            WarriorGenericDelegate<string, int> test2 = (SportsmanSkillValidator.TestGenericDelegate);
        }


        private bool ToJestTest(SportsmanSkill skill)
        {
            //skill.
            return false;
        }
    }
}
