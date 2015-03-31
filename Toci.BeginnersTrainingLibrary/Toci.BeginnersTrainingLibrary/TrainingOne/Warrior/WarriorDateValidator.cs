using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Warrior
{
    public class WarriorDateValidator : IDateValidator
    {
        const int monthLimit = 13;


        public bool CheckDate(int year, int month, int day)
        {
            if (month < 13)
            {
                //if ()
            }

            return true;
        }

        public string GetNick()
        {
            return "Ghost Rider";
        }
    }
}
