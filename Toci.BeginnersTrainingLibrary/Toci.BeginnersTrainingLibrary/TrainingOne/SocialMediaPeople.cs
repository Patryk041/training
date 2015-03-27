using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Dysq;
using Toci.BeginnersTrainingLibrary.TrainingOne.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne
{
    public class SocialMediaPeople
    {
        public bool SavePeople(IHuman people)
        {
            //people.
            return true;
        }

        private void test()
        {
            SavePeople(new Player());
            SavePeople(new President());
        }
    }
}
