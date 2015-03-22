using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq.Helper;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Dysq
{
    public class SportsMan
    {
        private int _age = 18;
        protected string Name;
        protected string Surname;
        protected string SportsField;
        public bool allowed;

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
            Name = name;
            Surname = surname;
            SportsField = sportsField;
            _age = age;

            allowed = AllowedToPlay.CheckPlayer(this);

        }

        
    }
}
